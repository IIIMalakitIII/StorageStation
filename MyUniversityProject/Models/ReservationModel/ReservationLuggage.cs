using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models.ReservationModel
{
    public class ReservationLuggage
    {
        [Required]
        public DateTime StartReservation { get; set; }
        public string Time { get; set; }

        [Required]
        public int HowManyHours { get; set; }

        public List<Luggage> Luggages { get; set; } = new List<Luggage>();
    }
}
