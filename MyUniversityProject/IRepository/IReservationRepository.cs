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
        Reservation Create(ref ReservationLuggage reservationLuggage);
    }
}
