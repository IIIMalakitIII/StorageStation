﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MyUniversityProject.Models;
using MyUniversityProject.Models.FilterModel;
using MyUniversityProject.Models.Pagination;
using MyUniversityProject.Models.ReservationViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.IRepository
{
    public interface IReservationRepository
    {
        Task<ReservationLuggage> Create(ReservationLuggage reservationLuggage, string Email);
        Task<int> CreateReservation(Cell cell, string Email, ReservationLuggage reservationLuggage);
        Task<Reservation> GetReservation(int id);
        Task<string> SaveAsync();
        Task<List<Cell>> GetCells(ReservationLuggage reservationLuggage);
        Task<List<Reservation>> GetUserReservations(int userId);
        Task<MemoryStream> ResultFile(int id);
        Task<List<SelectListItem>> GetFreeStorage();
        Task<List<Cell>> GetAllCell(string location);
        IEnumerable<Reservation> GetSortReserve(IEnumerable<Reservation> list, string SortItem);
        Task<IndexReserveModel> GetUserReservations(int userId, int page, ReserveFilterViewModel reserve);
        Task<IEnumerable<Reservation>> GetSearchingReserve(int userId, ReserveFilterViewModel reserve);
        Task<IndexReserveAdminModel> GetReservations(int page, ReserveAdminViewModel reserve);
        Task<IEnumerable<Reservation>> GetSearchingReserve(ReserveAdminViewModel reserve);
        Task<string> DeleteReservation(int reserveId);
        Task<string> UpdateReserve(Reservation reserve);


    }
}
