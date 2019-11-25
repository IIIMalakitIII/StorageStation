using MyUniversityProject.Models.FilterModel;
using System.Collections.Generic;

namespace MyUniversityProject.Models.Pagination
{
    public class IndexReserveModel
    {
        public List<Reservation> Reservations { get; set; }
        public ReserveFilterViewModel ReserveFilterViewModel { get; set; }
        public PageViewModel PageViewModel { get; set; }
        
    }

}
