using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightsDatabase.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public int FlightId { get; set; }
        public int PassagerId { get; set; }

        public virtual Flight Flight { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}
