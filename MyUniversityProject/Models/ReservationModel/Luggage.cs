using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models.ReservationModel
{
    public class Luggage
    {
        [Required]
        public int Width { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Length { get; set; }
        [Required]
        public int Capacity { get; set; }
    }
}
