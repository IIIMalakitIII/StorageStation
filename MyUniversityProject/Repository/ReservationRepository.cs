using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.ReservationModel;
using MyUniversityProject.Serviece;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Repository
{
    public class ReservationRepository: IReservationRepository
    {
        private readonly DataContext dataContext;


        public ReservationRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;

        }

        public Reservation Create(ref ReservationLuggage reservationLuggage)
        {
            var Cells =  dataContext.Cells
                .Where(blog => blog.Status)
                .Include(blog => blog.Storage)
                .Include(blog => blog.Standard)
                //.Include("Cells.Standard")
                .ToList();
            //if (reservationLuggage.Luggages.Count == 0)
            //{
            //    LinqExtensions.
            //    var b = Cells.Min(g => g.Standard.Price && (g.Width* g.Capacity * g.Length)==() );
            //}
            //List<string> b = new List<string>();
            //foreach (var c in new[] { "1", "2", "3", "4", "5" }.CombinationsWithoutRepetition(ofLength: 1, upToLength: 5))
            //{
            //    b.Add(string.Join(',', c));
            //    //Console.WriteLine(string.Join(',', c));
            //}
            var b = new Reservation();
            b.CellId = 1;
            b.EndReservation = DateTime.Now;
            b.StartReservation = DateTime.Now;
            b.Status = false;
            b.ReservationId = 0;
            b.Price = 516;

            return b;
        }
    }
}
