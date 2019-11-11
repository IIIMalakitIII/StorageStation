using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models
{
    public class UserInfo
    {
        [Key]
        public int UserInfoId { get; set; }

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
        public string PassportId { get; set; }
        [Required(ErrorMessage = "Something is wrong")]
        [StringLength(30, MinimumLength = 3)]
        public string PhoneNumber { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
