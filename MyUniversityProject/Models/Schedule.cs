using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyUniversityProject.Models
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }
        [Required]
        public string WeekDay { get; set; }
        [Required(ErrorMessage = "Start Work is requred")]
        [DataType(DataType.DateTime)]
        public DateTime StartWork { get; set; }
        [Required(ErrorMessage = "End Work is requred")]
        [DataType(DataType.DateTime)]
        public DateTime EndWork { get; set; }
        [ForeignKey(nameof(Storage))]
        public int StorageId { get; set; }
        public Storage Storage { get; set; }
        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}