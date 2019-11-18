using Microsoft.AspNetCore.Mvc.Rendering;
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
        [Required]
        public bool DivideTheLuggage { get; set; }
        public string SelectedStorage { get; set; }
        public string Exeception { get; set; }
        public int ReservationId { get; set; }
        public bool SomethingElse { get; set; }
        public List<Luggage> Luggages { get; set; } = new List<Luggage>();
        public List<SelectListItem> Storages { get; set; } = new List<SelectListItem>();
    }
}
