using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models.ReservationModel;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

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

        public async Task<IActionResult> Print(int id)
        {
            var stream = await reservationRepository.ResultFile(id);
            return File(stream, "application/msword", "Result.docx");
        }

    }
}

