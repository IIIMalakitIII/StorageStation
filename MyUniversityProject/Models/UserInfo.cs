﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyUniversityProject.Models
{
    public class UserInfo
    {
        [Key]
        public int UserInfoId { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email is invalid")]
        [Required]
        public string Email { get; set; }
        [Required(ErrorMessage = "Address is requred")]
        [StringLength(100, MinimumLength = 3)]
        public string Address { get; set; }
        [Required(ErrorMessage = "FirstName is requred")]
        [StringLength(80, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is requred")]
        [StringLength(80, MinimumLength = 3)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone Number is requred")]
        [StringLength(30, MinimumLength = 3)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Password is requred")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string PassportId { get; set; }
        [StringLength(10, MinimumLength = 3)]
        public string Role { get; set; }
        public virtual List<Reservation> Reservations { get; set; }




    }
}
