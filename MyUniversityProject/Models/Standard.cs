using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models
{
    public class Standard
    {
        [Key]
        public int StandardId { get; set; }
        [Required]
        public int MinVolume { get; set;}
        [Required]
        public int MaxVolume { get; set; }
        [Required]
        public decimal Price { get; set; }

        public List<Cell> Cells { get; set; } = new List<Cell>();
    }
}
