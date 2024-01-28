global using LafargeApp.Shared;
global using LafargeApp.Client.Services.LocationService;
using LafargeApp.Client;
using LafargeApp.Client.Services.DriverService;
using LafargeApp.Client.Services.TruckService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ITruckService, TruckService>();
builder.Services.AddScoped<IDriverService, DriverService>();
builder.Services.AddScoped<ILocationService, LocationService>();

await builder.Build().RunAsync();
