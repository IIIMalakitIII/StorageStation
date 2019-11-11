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
        public IActionResult Index(ReservationLuggage reservationLuggage)
        {
            reservationLuggage.StartReservation = reservationLuggage.StartReservation.Add(TimeSpan.Parse(reservationLuggage.Time));
            if (ModelState.IsValid)
            {
                var reservations  = reservationRepository.Create(ref reservationLuggage);
                return RedirectToAction(nameof(Result), new { id = reservations.ReservationId });
            }
            return View(reservationLuggage);
        }


        [HttpGet]
        public IActionResult Result(int id,[FromBody] ReservationLuggage reservationLuggage)
        {
            ViewBag.Luggaes = reservationLuggage;
            return View("ReservationResult", reservationLuggage);
        }


    }
}