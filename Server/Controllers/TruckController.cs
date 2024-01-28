using AspNetCoreRateLimit;
using LafargeApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LafargeApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[MiddlewareFilter(typeof(IpRateLimitMiddleware))]
    public class TruckController : ControllerBase
    {
        private readonly DataContext _context;

        public TruckController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Truck>))]
        public async Task<IActionResult> GetTrucks()
        {
            //adding logs
            var logEntry = new Log { Action = "GetDrivers", Details = "", ActionBy = "", DateCreated = DateTime.UtcNow };
            var log = _context.Logs.Add(logEntry);

            //getting list of trucks
            var trucks = _context.Trucks.ToList();
            return Ok(trucks);
        }
    }
}
