using MyUniversityProject.Models.FilterModel;
using System.Collections.Generic;

namespace MyUniversityProject.Models.Pagination
{
    public class IndexReserveAdminModel
    {
        public List<Reservation> Reservations { get; set; }
        public ReserveAdminViewModel ReserveAdminViewModel { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
