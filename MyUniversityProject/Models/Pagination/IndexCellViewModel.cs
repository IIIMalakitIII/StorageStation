using MyUniversityProject.Models.FilterModel;
using System.Collections.Generic;

namespace MyUniversityProject.Models.Pagination
{
    public class IndexCellViewModel
    {
        public IEnumerable<List<Cell>> Cells { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public CellFilterViewModel CellFilterViewModel { get; set; }
    }
}
