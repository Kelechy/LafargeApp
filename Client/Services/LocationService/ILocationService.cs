

namespace LafargeApp.Client.Services.LocationService
{
    public interface ILocationService
    {
        Location location { get; set; }
        Task<Location> GetLocationByAssetId(decimal assetId);
        Task<Location> GetLocationByDriverId(decimal driverId);
        Task<double> GetDistance(double lat1, double lon1, double lat2, double lon2);
    }
}
