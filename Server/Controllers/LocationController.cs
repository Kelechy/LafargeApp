using AspNetCoreRateLimit;
using LafargeApp.Server.Utility;
using LafargeApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LafargeApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[MiddlewareFilter(typeof(IpRateLimitMiddleware))]
    public class LocationController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IDistanceCalculation _distance;

        public LocationController(DataContext context, IDistanceCalculation distance)
        {
            _context = context;
            _distance = distance;
        }


        [HttpGet]
        [ProducesResponseType(200, Type = typeof(Location))]
        public async Task<IActionResult> GetLocationByAssetId(decimal AssestId)
        {
            //adding logs
            var logEntry = new Log { Action = "GetDrivers", Details = AssestId.ToString(), ActionBy = "", DateCreated = DateTime.UtcNow };
            var log = _context.Logs.Add(logEntry);

            //getting location by assetId
            var location = _context.Locations.FirstOrDefault(i => i.AssetId == AssestId);
            if (location == null)
            {
                return NotFound("location not found!!");
            }
            return Ok(location);
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(Location))]
        public async Task<IActionResult> GetLocationByDriverId(decimal driverId)
        {
            //adding logs
            var logEntry = new Log { Action = "GetLocationBy", Details = driverId.ToString(), ActionBy = "", DateCreated = DateTime.UtcNow };
            var log = _context.Logs.Add(logEntry);

            //getting location by driverId
            var location = _context.Locations.FirstOrDefault(i => i.DriverId == driverId);
            if (location == null)
            {
                return NotFound("location not found!!");
            }
            return Ok(location);
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(double))]
        public async Task<IActionResult> GetDistance(double lat1, double lon1, double lat2, double lon2)
        {
            var distance = _distance.CalculateDistance(lat1, lon1, lat2, lon2);
            
            return Ok(distance);
        }
    }
}
