using LafargeApp.Client.Pages;
using LafargeApp.Shared;
using System.Net.Http.Json;

namespace LafargeApp.Client.Services.DriverService
{
    public class DriverService : IDriverService
    {
        private readonly HttpClient _client;
        public DriverService(HttpClient client)
        {
            _client = client;
        }
        public List<Driver> Drivers { get; set; }

        public async Task GetDrivers()
        {
            try
            {
                var result = await _client.GetFromJsonAsync<List<Driver>>("api/driver");
                if (result != null)
                    Drivers = result;
                else { Drivers = new List<Driver>(); }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
