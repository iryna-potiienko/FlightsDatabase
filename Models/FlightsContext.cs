using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightsDatabase.Models
{
    public class FlightsContext: DbContext, IRepository
    {
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<Plane> Planes { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }

        public FlightsContext(DbContextOptions<FlightsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public void MarkAsModified<T>(T item)
        {
            Entry(item).State = EntityState.Modified;
        }

        public Task Save()
        {
            return SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>()
                        .HasOne(m => m.AirportDeparture)
                        .WithMany(t => t.FlightsDeparture)
                        .HasForeignKey(m => m.AirportDepartureId)
            .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Flight>()
                        .HasOne(m => m.AirportArrival)
                        .WithMany(t => t.FlightsArrival)
                        .HasForeignKey(m => m.AirportArrivalId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Passenger>()
                .HasKey(p => p.Passport)
                .HasName("PK_Passport");
        }
    }
}
