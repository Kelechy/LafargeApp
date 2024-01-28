using LafargeApp.Shared;
using System.Net.Http.Json;

namespace LafargeApp.Client.Services.TruckService
{
    public class TruckService : ITruckService
    {
        private readonly HttpClient _client;

        public TruckService(HttpClient client)
        {
            _client = client;
        }

        public List<Truck> Trucks { get; set; }

        public async Task GetTrucks()
        {
            var result = await _client.GetFromJsonAsync<List<Truck>>("api/truck");
            if (result != null)
                Trucks = result;

        }
    }
}
