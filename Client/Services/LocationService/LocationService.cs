using System.Net.Http.Json;

namespace LafargeApp.Client.Services.LocationService
{
    public class LocationService : ILocationService
    {
        private readonly HttpClient _client;
        public Location location { get; set; }

        public async Task<Location> GetLocationByAssetId(decimal assetId)
        {
            var result = await _client.GetFromJsonAsync<Location>($"api/location/{assetId}");
            if (result != null)
                location = result;
            return location;
            throw new Exception("Location not found");
        }

        public async Task<Location> GetLocationByDriverId(decimal driverId)
        {
            var result = await _client.GetFromJsonAsync<Location>($"api/location/{driverId}");
            if (result != null)
                location = result;
            return location;
            throw new Exception("Location not found");
        }

        public async Task<double> GetDistance(double lat1, double lon1, double lat2, double lon2)
        {
            var distance = await _client.GetFromJsonAsync<double>($"api/location/{lat1},{lon1},{lat2},{lon2}");
            
            return distance;
        }
    }
}
