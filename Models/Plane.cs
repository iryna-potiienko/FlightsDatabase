using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Назва")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Кількість місць")]
        public int Places { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }

    }
}
