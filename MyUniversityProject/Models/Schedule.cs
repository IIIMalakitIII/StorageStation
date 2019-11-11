using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public string WeekDay { get; set; }

        public DateTime StartWork { get; set; }
        public DateTime EndWork { get; set; }
        [ForeignKey(nameof(Storage))]
        public int StorageId { get; set; }
        public Storage Storage { get; set; }
        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}