using AspNetCoreRateLimit;
using LafargeApp.Server.Utility;
using LafargeApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;

namespace LafargeApp.Server.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [MiddlewareFilter(typeof(IpRateLimitMiddleware))]
    public class DriverController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IUtility _utility;

        public DriverController(DataContext context, IUtility utility)
        {
            _context = context;
            _utility = utility;
        }

        [HttpGet("api/driver")]
        [ProducesResponseType(200, Type = typeof(List<Driver>))]
        public async Task<IActionResult> GetDrivers()
        {
            //adding logs
            var logEntry = new Log { Action = "GetDrivers", Details = "", ActionBy = "", DateCreated = DateTime.UtcNow };
            var log =  _context.Logs.Add(logEntry);

            //getting list of drivers
            var drivers = await _context.Drivers.ToListAsync();
            return Ok(drivers);
        }
    }
}
