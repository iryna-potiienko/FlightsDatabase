using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightsDatabase.Models
{
    public class Flight
    {
        public Flight()
        {
            Tickets = new List<Ticket>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeDeparture { get; set; }
        public DateTime TimeArrival { get; set; }
        public DateTime Date { get; set; }

        public int PlaneId { get; set; }
        public int AirportDepartureId { get; set; }
        public int AirportArrivalId { get; set; }
        

        public virtual Plane Plane { get; set; }
        public virtual Airport AirportDeparture { get; set; }
        public virtual Airport AirportArrival { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
