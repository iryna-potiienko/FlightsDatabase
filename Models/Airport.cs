using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightsDatabase.Models
{
    public class Airport
    {
        public Airport()
        {
            Flights = new List<Flight>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
