using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models.ReservationViewModel;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using MyUniversityProject.Models.FilterModel;

namespace MyUniversityProject.Controllers
{

    public class ReservationController : Controller
    {
        private readonly IReservationRepository reservationRepository;
        public ReservationController(IReservationRepository reservationRepository)
        {
            this.reservationRepository = reservationRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            ReservationLuggage reservation = new ReservationLuggage();
            reservation.Storages = await reservationRepository.GetFreeStorage();
            //ViewBag.StorageList = await reservationRepository.GetFreeStorage();
            return View(reservation);
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Index(ReservationLuggage reservationLuggage)
        {
            if (ModelState.IsValid)
            {
                reservationLuggage.StartReservation = reservationLuggage.StartReservation.Add(TimeSpan.Parse(reservationLuggage.Time));//add time 
                reservationLuggage.SelectedStorage = reservationLuggage.SelectedStorage == null ? "" : reservationLuggage.SelectedStorage;
                var reservations = await reservationRepository.Create(reservationLuggage, User.Identity.Name);
                if (reservations.SomethingElse)
                {
                    ModelState.AddModelError("", reservationLuggage.Exeception);
                    return View(reservationLuggage);
                }
                var b = JsonConvert.SerializeObject(reservations);
                return RedirectToAction(nameof(Result), new { obj = b });
            }
            return View(reservationLuggage);
        }

        //[HttpGet]
        //[Authorize]
        //public async Task<IActionResult> Result(int id, string desription)
        //{
        //    var model = await reservationRepository.GetReservation(id);
        //    ViewBag.Description = HttpUtility.HtmlDecode(desription);
        //    return View(model);
        //}

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Result(string obj)
        {
            var model = JsonConvert.DeserializeObject<ReservationLuggage>(obj);
            var model2 = await reservationRepository.GetReservation(model.ReservationId);
            ViewBag.Description = model.Luggages;
            return View(model2);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Print(int id)
        {
            var stream = await reservationRepository.ResultFile(id);
            return File(stream, "application/msword", "Result.docx");
        }

        [HttpGet]
        [Authorize(Roles = "Admin, SuperUser")]
        public async Task<IActionResult> GetReservations([Bind(
            "SearchFilter," +
            "SortItem," +
            "MinPrice," +
            "MaxPrice," +
            "SearchValue," +
            "FirstDate," +
            "SecondDate")] ReserveAdminViewModel reserveAdmin,int page=1)
        {
            var errMsg = TempData["ErrorMessage"];

            if (errMsg != null)
            {
                ModelState.AddModelError("", errMsg as string);
            }
            var model = await reservationRepository.GetReservations(page, reserveAdmin);
            return View("Reservations", model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, SuperUser")]
        public async Task<IActionResult> DeleteReserve(int reserveId, int page = 1)
        {
            /* Сообщить пользователю*/
            var result = await reservationRepository.DeleteReservation(reserveId);
            TempData["ErrorMessage"] = result;
            return RedirectToAction(nameof(GetReservations), new { page = page });
        }

        [HttpGet]
        [Authorize(Roles = "Admin, SuperUser")]
        public async Task<IActionResult> GetReserve(int Id)
        {
            /* Сообщить пользователю*/
            var result = await reservationRepository.GetReservation(Id);
            if(result == null)
            {
                return RedirectToAction(nameof(GetReservations));
            }
            return View(result);
        }

    }
}

