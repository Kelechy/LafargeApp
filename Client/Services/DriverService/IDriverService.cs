using LafargeApp.Shared;

namespace LafargeApp.Client.Services.DriverService
{
    public interface IDriverService
    {
        List<Driver> Drivers { get; set; }
        Task GetDrivers();
    }
}
