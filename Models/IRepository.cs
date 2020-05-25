using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightsDatabase.Models
{
    public interface IRepository
    {
        DbSet<Country> Countries { get; set; }
        DbSet<Airport> Airports { get; set; }
        DbSet<Ticket> Tickets { get; set; }
        DbSet<Flight> Flights { get; set; }
        DbSet<Plane> Planes { get; set; }
        DbSet<Passenger> Passengers { get; set; }
        void MarkAsModified<T>(T item);
        EntityEntry Entry(object entity);
        Task Save();
    }
}
