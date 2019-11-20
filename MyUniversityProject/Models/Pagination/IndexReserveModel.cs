using MyUniversityProject.Models.FilterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models.Pagination
{
    public class IndexReserveModel
    {
        public List<Reservation> Reservations { get; set; }
        public ReserveFilterViewModel ReserveFilterViewModel { get; set; }
        public PageViewModel PageViewModel { get; set; }
        
    }

}
