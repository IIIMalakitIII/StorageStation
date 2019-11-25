using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyUniversityProject.Models
{
    public class Cell
    {
        [Key]
        public int CellId { get; set; }
        [Required(ErrorMessage = "Width is requred")]
        [Range(1, 99999, ErrorMessage = "Invalid value")]
        public int Width{ get; set; }
        [Required(ErrorMessage = "Height is requred")]
        [Range(1, 99999, ErrorMessage = "Invalid value")]
        public int Height { get; set; }
        [Required(ErrorMessage = "Length is requred")]
        [Range(1, 99999, ErrorMessage = "Invalid value")]
        public int Length { get; set; }
        [Required(ErrorMessage = "Capacity is requred")]
        [Range(1, 99999, ErrorMessage = "Invalid value")]
        public int Capacity { get; set; }
        [Required]
        public bool Status { get; set; }

        public List<Reservation> Reservations { get; set; }

        [ForeignKey(nameof(Standard))]
        public int StandardId { get; set; }
        public Standard Standard { get; set; }
        [ForeignKey(nameof(Storage))]
        public int StorageId { get; set; }
        public Storage Storage { get; set; }
    }
}
