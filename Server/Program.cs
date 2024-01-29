global using Microsoft.EntityFrameworkCore;
global using LafargeApp.Shared;
global using LafargeApp.Server.Data;
using Microsoft.AspNetCore.ResponseCompression;
using LafargeApp.Client.Services.LocationService;
using LafargeApp.Server.Utility;
using AspNetCoreRateLimit;
using Microsoft.Extensions.Configuration;
using Server.SeededData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMemoryCache();
builder.Services.Configure<IpRateLimitOptions>(builder.Configuration.GetSection("IpRateLimiting"));
builder.Services.AddInMemoryRateLimiting();  // Corrected line
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
builder.Services.AddScoped<IUtility, Utility>();
builder.Services.AddScoped<IDistanceCalculation, DistanceCalculation>();
builder.Services.AddScoped<ISqlConnectionFactory>( c => {
    return new SqlConnectionFactory(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<SeedData>();

// ...

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseIpRateLimiting();
//app.UseClientRateLimiting();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

try
{
    var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<DataContext>();
    context.Database.Migrate();

    var dataSeeder = scope.ServiceProvider.GetRequiredService<SeedData>();
    Task.Run(async () => await dataSeeder.Create()).GetAwaiter().GetResult();

}
catch(Exception ex){app.Logger.LogError(ex, ex.Message);}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseMiddleware<IpRateLimitMiddleware>();
//app.UseIpRateLimiting();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
