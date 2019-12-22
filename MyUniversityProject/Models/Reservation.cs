using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyUniversityProject.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required(ErrorMessage = "Start Reservation is requred")]
        [DataType(DataType.DateTime)]
        public DateTime StartReservation { get; set; }

        [Required(ErrorMessage = "End Reservation is requred")]
        [DataType(DataType.DateTime)]
        public DateTime EndReservation { get; set; }

        public bool Status { get; set; }
        [Range(typeof(decimal), "1.00", "999999.99", ErrorMessage = "Invalid value")]
        public decimal Amount { get; set; }

        [ForeignKey(nameof(Cell))]
        public int CellId { get; set; }

        public Cell Cell { get; set; }

        [ForeignKey(nameof(UserInfo))]
        public int UserInfoId { get; set; }

        public UserInfo UserInfo { get; set; }

    }
}
