using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.FilterModel;
using MyUniversityProject.Models.Pagination;
using MyUniversityProject.Models.ReservationViewModel;
using MyUniversityProject.Serviece;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Repository
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly DataContext dataContext;

        public ReservationRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;

        }

        public async Task<ReservationLuggage> Create(ReservationLuggage reservationLuggage, string Email)
        {
            reservationLuggage.SomethingElse = false; // haven't got any problem 
            List<Cell> filterCells = await GetCells(reservationLuggage);

            if (filterCells.Count == 0)
            {
                reservationLuggage.SomethingElse = true;
                reservationLuggage.Exeception = "Sorry, but all cells are reserved, try at another time.";
                return reservationLuggage; //вернуть сообщение о том что нет свободных ячеек
            }

            Cell resultCell = null;
            List<Luggage> luggage = new List<Luggage>(); //список багажей которые не поместились
            //reservationLuggage.Luggages.RemoveAll(x => x.Height == 0 || x.Width == 0 || x.Length == 0);

            if (reservationLuggage.Luggages.Count == 0)
            {
                foreach (var cell in filterCells)
                {
                    if (resultCell == null)
                    {
                        resultCell = cell;
                    }
                    else
                    {
                        if (resultCell.Standard.Price > cell.Standard.Price)
                        {
                            resultCell = cell;
                        }
                    }
                }
            }
            else
            {
                int[] result = SelectionAlgorithm.Algo(filterCells, reservationLuggage.Luggages);
                if (result[0] == -1)
                {
                    reservationLuggage.SomethingElse = true;
                    reservationLuggage.Exeception = "Sorry, but we couldn't find a suitable cell.";
                    return reservationLuggage; //вернуть то что нет подходящей ячейки
                }
                if (result.Length > 1 && !reservationLuggage.DivideTheLuggage)
                {
                    reservationLuggage.SomethingElse = true;
                    reservationLuggage.Exeception = "Sorry, but we couldn't find a suitable cell.";
                    return reservationLuggage;
                }

                for (int i = 0; i < result.Length - 1; i++)
                {
                    luggage.Add(reservationLuggage.Luggages[result[i + 1]]);
                }

                resultCell = filterCells.FirstOrDefault(x => x.CellId == result[0]); // берем подобранную ячейку
            }
            var newCreateReservationId = await CreateReservation(resultCell, Email, reservationLuggage);

            if (newCreateReservationId == 0)
            {
                reservationLuggage.SomethingElse = true;
                reservationLuggage.Exeception = "Something is wrong, try another time";
                return reservationLuggage;
            }
            else
            {
                reservationLuggage.Luggages = luggage;
                reservationLuggage.ReservationId = newCreateReservationId;
                return reservationLuggage;
            }
        }
        public async Task<int> CreateReservation(Cell cell, string Email, ReservationLuggage reservationLuggage)
        {
            var userInfo = await dataContext.UserInfos
                .AsNoTracking()
                .Where(o => o.Email == Email)
                .FirstOrDefaultAsync();

            if (userInfo == null)
            {
                return 0;
            }

            Reservation reservation = new Reservation();
            reservation.StartReservation = reservationLuggage.StartReservation;
            reservation.Amount = cell.Standard.Price * reservationLuggage.HowManyHours;
            reservation.EndReservation = reservationLuggage.StartReservation.AddHours(reservationLuggage.HowManyHours);
            reservation.UserInfoId = userInfo.UserInfoId;
            reservation.CellId = cell.CellId;
            reservation.Status = true;
            dataContext.Reservations.Add(reservation);
            await SaveAsync();

            return reservation.ReservationId;
        }


        public async Task<Reservation> GetReservation(int id) =>
             await dataContext.Reservations.Include(o => o.UserInfo).Where(o => o.ReservationId == id).FirstOrDefaultAsync();

        public async Task SaveAsync() =>
            await dataContext.SaveChangesAsync();


        public async Task<List<Cell>> GetCells(ReservationLuggage reservationLuggage)
        {
            var Cells = await GetAllCell(reservationLuggage.SelectedStorage);
            var filterCells = new List<Cell>();
            var EndTimeReserve = reservationLuggage.StartReservation.AddHours(reservationLuggage.HowManyHours);
            foreach (var cell in Cells)
            {
                bool addCell = cell.Reservations.Any(reserve =>
                    (reserve.StartReservation <= reservationLuggage.StartReservation &&
                    reserve.EndReservation >= reservationLuggage.StartReservation) ||
                    (reservationLuggage.StartReservation <= reserve.StartReservation &&
                    EndTimeReserve >= reserve.StartReservation));

                if (!addCell)
                {
                    filterCells.Add(cell);
                }
            }
            return filterCells;
        }

        public async Task<MemoryStream> ResultFile(int id)
        {
            var reservation = await GetReservation(id);
            using (WordDocument document = new WordDocument())
            {
                document.EnsureMinimal();
                document.LastParagraph.AppendText($"Reservation Id: {reservation.ReservationId} \n");
                document.LastParagraph.AppendText($"Price: {reservation.Amount} \n");
                document.LastParagraph.AppendText($"Start Reservation: {reservation.StartReservation} \n");
                document.LastParagraph.AppendText($"End Reservation: {reservation.EndReservation} \n");
                document.LastParagraph.AppendText($"Cell Id: {reservation.CellId} \n");
                document.LastParagraph.AppendText($"User Information: {reservation.UserInfo.FirstName} {reservation.UserInfo.LastName} \n");
                document.LastParagraph.AppendText($"User Id: {reservation.UserInfoId} \n");
                MemoryStream stream = new MemoryStream();
                document.Save(stream, FormatType.Docx);
                stream.Position = 0;
                return stream;
            }
        }

        public async Task<List<Cell>> GetAllCell(string location) =>
            await dataContext.Cells
                .AsNoTracking()
                .Include(blog => blog.Standard)
                .Include(blog => blog.Reservations)
                .Include(blog => blog.Storage)
                .Where(x => x.Storage.Location.Contains(location) && x.Storage.Status && x.Status && x.Reservations.All(r => r.Status))
                .ToListAsync();


        public async Task<List<SelectListItem>> GetFreeStorage()
        {
            return await dataContext.Storages
                .AsNoTracking()
                .Where(x => x.Status)
                .Select(x => new SelectListItem
                {
                    Text = x.Location,
                    Value = x.Location
                })
                .ToListAsync();
        }


        public async Task<List<Reservation>> GetUserReservations(int userId)
        {
            return await dataContext.Reservations
                .Include(x => x.Cell)
                .ThenInclude(x => x.Storage)
                .Where(x => x.UserInfoId == userId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetSearchingReserve(int userId, ReserveFilterViewModel reserve)
        {
            if(reserve.SearchFilter == "" && reserve.SearchValue!="Any")
            {
                return await dataContext.Reservations
                    .Include(x => x.Cell)
                    .ThenInclude(x => x.Storage)
                    .Where(x =>
                        x.UserInfoId == userId &&
                        x.Amount >= reserve.MinPrice &&
                        x.Amount <= reserve.MaxPrice &&
                        (reserve.FirstDate == null ? true : x.StartReservation >= reserve.FirstDate) &&
                        (reserve.SecondDate == null ? true : x.EndReservation <= reserve.SecondDate) &&
                        (x.Amount.ToString().Contains(reserve.SearchFilter) ||
                        x.ReservationId.ToString().Contains(reserve.SearchFilter) ||
                        x.StartReservation.ToString().Contains(reserve.SearchFilter) ||
                        x.EndReservation.ToString().Contains(reserve.SearchFilter) ||
                        x.CellId.ToString().Contains(reserve.SearchFilter) ||
                        x.Cell.Storage.Location.Contains(reserve.SearchFilter)
                        )
                    )
                    .ToListAsync();
            }

            switch (reserve.SearchValue)
            {
                case "Location":
                    return await dataContext.Reservations
                        .Include(x => x.Cell)
                        .ThenInclude(x => x.Storage)
                        .Where(x =>
                            x.UserInfoId == userId &&
                            x.Cell.Storage.Location.Contains(reserve.SearchFilter) &&
                            x.Amount >= reserve.MinPrice &&
                            x.Amount <= reserve.MaxPrice &&
                            (reserve.FirstDate == null ? true : x.StartReservation >= reserve.FirstDate) &&
                            (reserve.SecondDate == null ? true : x.EndReservation <= reserve.SecondDate)
                        )
                        .ToListAsync();
                case "CellId":
                    return await dataContext.Reservations
                        .Include(x => x.Cell)
                        .ThenInclude(x => x.Storage)
                        .Where(x =>
                            x.UserInfoId == userId &&
                            x.CellId.ToString().Contains(reserve.SearchFilter) &&
                            x.Amount >= reserve.MinPrice &&
                            x.Amount <= reserve.MaxPrice &&
                            (reserve.FirstDate == null ? true : x.StartReservation >= reserve.FirstDate) &&
                            (reserve.SecondDate == null ? true : x.EndReservation <= reserve.SecondDate)
                        )
                        .ToListAsync();
                case "ReservationId":
                    return await dataContext.Reservations
                        .Include(x => x.Cell)
                        .ThenInclude(x => x.Storage)
                        .Where(x =>
                            x.UserInfoId == userId &&
                            x.ReservationId.ToString().Contains(reserve.SearchFilter) &&
                            x.Amount >= reserve.MinPrice &&
                            x.Amount <= reserve.MaxPrice &&
                            (reserve.FirstDate == null ? true : x.StartReservation >= reserve.FirstDate) &&
                            (reserve.SecondDate == null ? true : x.EndReservation <= reserve.SecondDate)
                        )
                        .ToListAsync();
                case "Active":
                    bool any = reserve.SearchFilter.Contains("Active") ||
                        reserve.SearchFilter.Contains("active") ||
                        reserve.SearchFilter.Contains("true") ||
                        reserve.SearchFilter.Contains("True") ||
                        reserve.SearchFilter.Contains("1") ||
                        reserve.SearchFilter.Contains("activ");
                    return await dataContext.Reservations
                        .Include(x => x.Cell)
                        .ThenInclude(x => x.Storage)
                        .Where(x =>
                            x.UserInfoId == userId &&
                            x.Status == any &&
                            x.Amount >= reserve.MinPrice &&
                            x.Amount <= reserve.MaxPrice &&
                            (reserve.FirstDate == null ? true : x.StartReservation >= reserve.FirstDate) &&
                            (reserve.SecondDate == null ? true : x.EndReservation <= reserve.SecondDate)
                        )
                        .ToListAsync();
                default:
                    return await dataContext.Reservations
                        .Include(x => x.Cell)
                        .ThenInclude(x => x.Storage)
                        .Where(x =>
                            x.UserInfoId == userId &&
                            x.Amount >= reserve.MinPrice &&
                            x.Amount <= reserve.MaxPrice &&
                            (reserve.FirstDate == null ? true : x.StartReservation >= reserve.FirstDate) &&
                            (reserve.SecondDate == null ? true : x.EndReservation <= reserve.SecondDate) &&
                            (x.Amount.ToString().Contains(reserve.SearchFilter) ||
                            x.ReservationId.ToString().Contains(reserve.SearchFilter) ||
                            x.StartReservation.ToString().Contains(reserve.SearchFilter) ||
                            x.EndReservation.ToString().Contains(reserve.SearchFilter) ||
                            x.CellId.ToString().Contains(reserve.SearchFilter) ||
                            x.Cell.Storage.Location.Contains(reserve.SearchFilter)
                            )
                        )
                        .ToListAsync();
            }
        }

        public IEnumerable<Reservation> GetSortReserve(IEnumerable<Reservation> list, ReserveFilterViewModel reserve)
        {
            switch (reserve.SortItem)
            {
                case "Price_ASC":
                    return list.OrderBy(x => x.Amount);
                case "Price_DESC":
                    return list.OrderByDescending(x => x.Amount);
                case "StartDate_ASC":
                    return list.OrderBy(x => x.StartReservation);
                case "StartDate_DESC":
                    return list.OrderByDescending(x => x.StartReservation);
                case "EndDate_ASC":
                    return list.OrderBy(x => x.EndReservation);
                case "EndDate_DESC":
                    return list.OrderByDescending(x => x.EndReservation);
                default:
                    return list.OrderByDescending(x => x.ReservationId); ;
            }
        }


        public async Task<IndexReserveModel> GetUserReservations(int userId, int page, ReserveFilterViewModel reserve)
        {

            if (reserve == null)
            {
                reserve = new ReserveFilterViewModel();
                reserve.MinPrice = dataContext.Reservations.AsNoTracking().Where(x => x.UserInfoId == userId).Min(x => x.Amount);
                reserve.MaxPrice = dataContext.Reservations.AsNoTracking().Where(x => x.UserInfoId == userId).Max(x => x.Amount);
                reserve.FirstDate = dataContext.Reservations.AsNoTracking().Where(x => x.UserInfoId == userId).Min(x => x.StartReservation).Date;
                reserve.SecondDate = dataContext.Reservations.AsNoTracking().Where(x => x.UserInfoId == userId).Max(x => x.EndReservation).Date;
                reserve.SortItem = "";
                reserve.SearchValue = "";
            }
            reserve.SearchValue = reserve.SearchValue == null ? "Any" : reserve.SearchValue;
            reserve.SearchFilter = reserve.SearchFilter == null ? "" : reserve.SearchFilter;
            reserve.SortItem = reserve.SortItem == null ? "" : reserve.SortItem;

            if (reserve.MinPrice==0 && reserve.MaxPrice == 0)
            {
                reserve.MinPrice = dataContext.Reservations.AsNoTracking().Where(x => x.UserInfoId == userId).Min(x => x.Amount);
                reserve.MaxPrice = dataContext.Reservations.AsNoTracking().Where(x => x.UserInfoId == userId).Max(x => x.Amount);
            }

            IEnumerable<Reservation> item = new List<Reservation>();
            item = GetSortReserve(await GetSearchingReserve(userId, reserve), reserve);

            var count = item.Count();
            var skipCells = item.Skip((page - 1) * 3).Take(3).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, 3);
            IndexReserveModel viewModel = new IndexReserveModel
            {
                PageViewModel = pageViewModel,
                Reservations = skipCells,
                ReserveFilterViewModel = reserve
            };
            return viewModel;
        }
    }
}
