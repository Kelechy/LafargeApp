using LafargeApp.Shared;

namespace LafargeApp.Client.Services.TruckService
{
    public interface ITruckService
    {
        List<Truck> Trucks { get; set; }
        Task GetTrucks();
    }
}
