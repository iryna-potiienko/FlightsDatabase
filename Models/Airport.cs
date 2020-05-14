using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightsDatabase.Models
{
    public class Airport
    {
        public Airport()
        {
            FlightsDeparture = new List<Flight>();
            FlightsArrival = new List<Flight>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage ="Поле має бути непорожнім!")]
        [Display(Name ="Назва")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Місто")]
        public string City { get; set; }
        public int CountryId { get; set; }

       
        [Display(Name = "Країна")]
        public virtual Country Country { get; set; }
        //[NotMapped]
        
        public virtual ICollection<Flight> FlightsDeparture { get; set; }
       // [NotMapped]
        public virtual ICollection<Flight> FlightsArrival { get; set; }
    }
}
