using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models
{
    public class Cell
    {
        [Key]
        public int CellId { get; set; }
        [Required]
        public int Width{ get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Length { get; set; }
        [Required]
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
