using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyUniversityProject.Models
{
    public class Storage
    {
        [Key]
        public int StorageId { get; set; }
        [Required(ErrorMessage = "Location is requred")]
        [StringLength(80, MinimumLength = 3)]
        public string Location { get; set; }
        [Required(ErrorMessage = "Status is requred")]
        public bool Status { get; set; }
        public virtual List<Cell> Cells {get;set;}
        public virtual List<Schedule> Schedules { get; set; }

    }
}
