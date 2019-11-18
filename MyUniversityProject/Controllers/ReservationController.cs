using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models.ReservationModel;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Web;

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
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Index(ReservationLuggage reservationLuggage)
        {
            if (ModelState.IsValid)
            {
                reservationLuggage.StartReservation = reservationLuggage.StartReservation.Add(TimeSpan.Parse(reservationLuggage.Time));//add time 
                var reservations = await reservationRepository.Create(reservationLuggage, User.Identity.Name);
                if (reservations.SomethingElse)
                {
                    ModelState.AddModelError("", reservationLuggage.Exeception);
                    return View(reservationLuggage);
                }
                var b = JsonConvert.SerializeObject(reservations);
                return RedirectToAction(nameof(Result), new { obj = b });
                //return RedirectToAction(nameof(Result), new { id = reservations.ReservationId, desription = reservations.NotFit });
            }
            ModelState.AddModelError("","Something is wrong");
            return View(reservationLuggage);
        }

        //[HttpGet]
        //[Authorize]
        //public async Task<IActionResult> Result(int id, string desription)
        //{
        //    var model = await reservationRepository.GetReservation(id);
        //    ViewBag.Description = HttpUtility.HtmlDecode(desription);
        //    return View("ReservationResult", model);
        //}

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Result(string obj)
        {
            var model = JsonConvert.DeserializeObject<ReservationLuggage>(model1);
            var model2 = await reservationRepository.GetReservation(model.ReservationId);
            ViewBag.Description = model.Luggages;
            return View("ReservationResult", model2);
        }
    }
}