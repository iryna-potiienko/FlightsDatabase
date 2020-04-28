using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlightsDatabase.Models
{
    public class Country
    {
        public Country()
        {
            Airports = new List<Airport>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Назва")]
        public string Name { get; set; }

        public virtual ICollection<Airport> Airports { get; set; }
    }
}
