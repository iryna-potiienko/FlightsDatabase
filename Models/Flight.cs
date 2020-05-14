using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Назва")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Час відправлення")]
        public DateTime TimeDeparture { get; set; }
        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Дата відправлення")]
        public DateTime DateDeparture { get; set; }
        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Час прибуття")]
        public DateTime TimeArrival { get; set; }
        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Дата прибуття")]
        public DateTime DateArrival{ get; set; }

        public int PlaneId { get; set; }
        //Потрібні 2 різних ForeignKey на таблицю Airport
        //Таким чином як тут це правильно організовувати?
        //[OnDeleteNoAction]
        //[NotMapped]
        public int AirportDepartureId { get; set; }
        public int AirportArrivalId { get; set; }

        [Display(Name = "Назва літака")]
        public virtual Plane Plane { get; set; }
        [ForeignKey("AirportDepartureId")]
        [Display(Name = "Відправлення з аіропорту")]
        public virtual Airport AirportDeparture { get; set; }
        [ForeignKey("AirportArrivalId")]
        [Display(Name = "Прибуття у аіропорт")]
        public virtual Airport AirportArrival { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
