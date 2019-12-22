using System.ComponentModel.DataAnnotations;

namespace MyUniversityProject.Models.ReservationViewModel
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
