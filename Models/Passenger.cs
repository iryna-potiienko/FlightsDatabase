using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        //Для занесення пасажира до бази даних у пасажира обов'язково має бути паспорт
        //Якщо паспорту у людини немає, то квиток оформлюється на іншого пасажира бази, у якого він є (за згодою того відповідно)
        [Display(Name = "Номер паспорту")]
        [Key]
        public int Passport { get; set; }

        //можливо краще ПІБ зробити одним полем чи зробити поля "Ім'я_Прізвище" і "По-батькові"?
        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Прізвище")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "По-батькові")]
        public string Patronymic { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
