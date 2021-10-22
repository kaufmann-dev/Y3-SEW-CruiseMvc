using Microsoft.EntityFrameworkCore;
using Model.Entity;

namespace Model.Configuration
{
    public class CruiseDbContext : DbContext
    {
        public DbSet<Cruise> Cruises { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Cabins> Cabins { get; set; }
        public DbSet<Cruise_Has_Bookings_JT> Booked_Cruises { get; set; }
        public DbSet<Cruise_Has_Employees_JT> Cruise_Employees { get; set; }
        public DbSet<Cruise_Has_Routes_JT> Cruise_Routes { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees_ST> Employees { get; set; }
        public DbSet<Harbors> Harbors { get; set; }
        public DbSet<Routes_JT> Routes { get; set; }
        public DbSet<Ships> Ships { get; set; }
        
        public CruiseDbContext(DbContextOptions<CruiseDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}