using Microsoft.EntityFrameworkCore;
using Model.Entity;

namespace Model.Configuration
{
    public class CruiseDbContext : DbContext
    {
        public DbSet<Cruise> Cruises { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Cabin> Cabins { get; set; }
        public DbSet<CruiseHasBookingJT> BookedCruises { get; set; }
        public DbSet<CruiseHasEmployeeJT> CruiseEmployees { get; set; }
        public DbSet<CruiseHasRouteJT> CruiseRoutes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<EmployeeST> Employees { get; set; }
        public DbSet<Harbor> Harbors { get; set; }
        public DbSet<RouteJT> Routes { get; set; }
        public DbSet<Ship> Ships { get; set; }
        
        public CruiseDbContext(DbContextOptions<CruiseDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}