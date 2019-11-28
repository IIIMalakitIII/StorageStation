using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models.StorageViewModel
{
    public class SqlViewModel
    {
        public string SqlCommand { get; set; }
        public List<string> ColumName { get; set; } = new List<string>();
        public List<object[]> RowName { get; set; } = new List<object[]>();
    }
}
