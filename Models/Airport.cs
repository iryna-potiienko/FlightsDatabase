using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage ="Поле має бути непорожнім!")]
        [Display(Name ="Назва")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Місто")]
        public string City { get; set; }
        public int CountryId { get; set; }

       
        [Display(Name = "Країна")]
        public virtual Country Country { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
