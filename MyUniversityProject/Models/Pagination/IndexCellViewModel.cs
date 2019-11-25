using MyUniversityProject.Models.FilterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models.Pagination
{
    public class IndexCellViewModel
    {
        public IEnumerable<List<Cell>> Cells { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public CellFilterViewModel CellFilterViewModel { get; set; }
    }
}
