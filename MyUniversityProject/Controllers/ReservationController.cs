using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.ReservationModel;

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
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(ReservationLuggage reservationLuggage)
        {
            reservationLuggage.StartReservation = reservationLuggage.StartReservation.Add(TimeSpan.Parse(reservationLuggage.Time));
            if (ModelState.IsValid)
            {
                var reservations = await reservationRepository.Create(reservationLuggage, User.Identity.Name);
                if (reservations.SomethingElse)
                {
                    ModelState.AddModelError("", reservationLuggage.Exeception);
                    return View(reservationLuggage);
                }
                return RedirectToAction(nameof(Result), new { id = reservations.ReservationId, desription = reservations.NotFit });
            }
            return View(reservationLuggage);
        }


        [HttpGet]
        public async Task<IActionResult> Result(int id, string desription)
        {
            var model = await reservationRepository.GetReservation(id);
            ViewBag.Description = desription;
            return View("ReservationResult", model);
        }


    }
}