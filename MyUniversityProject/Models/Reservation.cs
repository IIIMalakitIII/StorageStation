using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required]
        public DateTime StartReservation { get; set; }

        [Required]
        public DateTime EndReservation { get; set; }

        public bool Status { get; set; }

        public decimal Price { get; set; }

        [ForeignKey(nameof(Cell))]
        public int CellId { get; set; }

        public Cell Cell { get; set; }

        [ForeignKey(nameof(UserInfo))]
        public int UserInfoId { get; set; }

        public UserInfo UserInfo { get; set; }

    }
}
