using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models.AuthenticationModel
{
    public class RegisterModel
    {
        //[Required]
        //public UserInfo User { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Something is wrong")]
        [Required]
        public string Email { get; set; }
        [Required(ErrorMessage = "Something is wrong")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Something is wrong")]
        [StringLength(150, MinimumLength = 3)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Something is wrong")]
        [StringLength(150, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Something is wrong")]
        [StringLength(150, MinimumLength = 3)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Something is wrong")]
        [StringLength(30, MinimumLength = 3)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}
