using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightsDatabase.Models;

namespace FlightsDatabase.Models
{
    public class Plane
    {
        public Plane()
        {
            Flights = new List<Flight>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Places { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }

    }
}
