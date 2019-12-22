using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyUniversityProject.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Something is wrong")]
        [Required]
        public string Email { get; set; }

        [Required(ErrorMessage = "Something is wrong")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Something is wrong")]
        [StringLength(150, MinimumLength = 3)]
        public string Position { get; set; }

        [Required(ErrorMessage = "Something is wrong")]
        [StringLength(150, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Something is wrong")]
        [StringLength(150, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Something is wrong")]
        [StringLength(30, MinimumLength = 3)]
        public string PassportId { get; set; }

        [Required(ErrorMessage = "Something is wrong")]
        public DateTime DataWorkStart { get; set; }

        [Required(ErrorMessage = "Something is wrong")]
        [StringLength(30, MinimumLength = 3)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Something is wrong")]
        public decimal Salary { get; set; }

        public string Role { get; set; }

    }
}