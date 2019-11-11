using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models
{
    public class Storage
    {
        [Key]
        public int StorageId { get; set; }
        [Required]
        public string Location { get; set; }
        public bool Status { get; set; }
        public virtual List<Cell> Cells {get;set;}

        public virtual List<Schedule> Schedules { get; set; }

    }
}
