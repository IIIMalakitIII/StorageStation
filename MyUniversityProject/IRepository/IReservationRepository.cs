using MyUniversityProject.Models;
using MyUniversityProject.Models.ReservationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.IRepository
{
    public interface IReservationRepository
    {
        Task<ReservationLuggage> Create(ReservationLuggage reservationLuggage, string Email);
        Task<Reservation> GetReservation(int id);
        Task SaveAsync();
        Task<List<Cell>> GetCells(ReservationLuggage reservationLuggage);
        Task<List<Cell>> GetAllCell();
    }
}
