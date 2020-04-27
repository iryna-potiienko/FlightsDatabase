using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightsDatabase.Models
{
    public class FlightsContext: DbContext
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
    }
}
