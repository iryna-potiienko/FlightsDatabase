using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlightsDatabase.Models
{
    public class Ticket
    {
        /*Допускається оформлення декількох квитків на одну людину
        Отже, допускаються повтори записів у цій таблиці
        (насправді це різні квитки, але називатися вони будуть однаково)*/
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле має бути непорожнім!")]
        [Display(Name = "Ціна")]
        public decimal Price { get; set; }

        public int FlightId { get; set; }
        public int PassengerId { get; set; }

        /*Буде встановлено контроль над тим, щоб кількість проданих квитків на рейс не
         перевищувала кількості місць у літаку (є кілька ідей щодо цього)*/
        [Display(Name = "Рейс")]
        public virtual Flight Flight { get; set; }
        [Display(Name = "Пасажир")]
        public virtual Passenger Passenger { get; set; }
    }
}
