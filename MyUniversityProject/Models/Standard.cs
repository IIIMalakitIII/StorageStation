using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyUniversityProject.Models
{
    public class Standard
    {
        [Key]
        public int StandardId { get; set; }
        [Required(ErrorMessage = "MinVolume is requred")]
        [Range(1, 99999, ErrorMessage = "Invalid value")]
        public int MinVolume { get; set;}
        [Required(ErrorMessage = "MaxVolume is requred")]
        [Range(1, 99999, ErrorMessage = "Invalid value")]
        public int MaxVolume { get; set; }
        [Required(ErrorMessage = "Price is requred")]
        [Range(typeof(decimal), "1.00", "999999.99", ErrorMessage = "Invalid value")]
        public decimal Price { get; set; }

        public List<Cell> Cells { get; set; } = new List<Cell>();
    }
}
