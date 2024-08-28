using Microsoft.EntityFrameworkCore;
using TicketApp.Core.Entities;

namespace TicketApp.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {  }

       

        public DbSet<Train> Trains { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<TripPrice> TripPrices { get; set; }
        public DbSet<TripStation> TripStations { get; set; }
        public DbSet<TripStatus> TripStatuses { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<TripGroup> TripGroups { get; set; }
        public DbSet<TripSchedule> TripSchedules { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }

    }
}
