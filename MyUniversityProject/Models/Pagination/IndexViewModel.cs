﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models.Pagination
{
    public class IndexViewModel
    {
        public IEnumerable<List<Cell>> Cells { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}