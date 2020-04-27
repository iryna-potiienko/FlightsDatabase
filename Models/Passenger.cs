using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightsDatabase.Models
{
    public class Passenger
    {
        public Passenger()
        {
            Tickets = new List<Ticket>();
        }
        public int Pasport { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
