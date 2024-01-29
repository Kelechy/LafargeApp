using Microsoft.EntityFrameworkCore;

namespace LafargeApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
