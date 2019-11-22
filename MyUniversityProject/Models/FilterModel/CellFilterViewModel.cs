﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models.FilterModel
{
    public class CellFilterViewModel
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Capacity { get; set; }
        public string SearchFilter { get; set; }
        public string SearchValue { get; set; }
        public string SortItem { get; set; }
        public IEnumerable<SelectListItem> SearchParams => _searchParams;
        private readonly List<SelectListItem> _searchParams = new List<SelectListItem>  { new SelectListItem { Text = "Any", Value = "Any" },
                                                                                    new SelectListItem { Text = "Width", Value = "Width"},
                                                                                    new SelectListItem { Text = "Height", Value = "Height"},
                                                                                    new SelectListItem { Text = "Length", Value = "Length"},
                                                                                    new SelectListItem { Text = "Capacity", Value = "Capacity"},
                                                                                    new SelectListItem { Text = "Standart Id", Value = "Standart_Id" },
                                                                                    new SelectListItem { Text = "Standart Price", Value = "Standart_Price" },
                                                                                    new SelectListItem { Text = "Status", Value = "Status" } };
        public IEnumerable<SelectListItem> SortList => _sortItems;
        private readonly List<SelectListItem> _sortItems = new List<SelectListItem> { new SelectListItem { Text = "Default", Value = "Default" },
                                                                                      new SelectListItem { Text = "Width (from Min to Max)", Value = "Width_ASC"},
                                                                                      new SelectListItem { Text = "Width (from Max to Min )", Value = "Width_DESC"},
                                                                                      new SelectListItem { Text = "Height (from Min to Max)", Value = "Height_ASC"},
                                                                                      new SelectListItem { Text = "Height (from Max to Min )", Value = "Height_DESC"},
                                                                                      new SelectListItem { Text = "Length (from Min to Max)", Value = "Length_ASC"},
                                                                                      new SelectListItem { Text = "Length (from Max to Min )", Value = "Length_DESC"},
                                                                                      new SelectListItem { Text = "Capacity (from Min to Max)", Value = "Capacity_ASC"},
                                                                                      new SelectListItem { Text = "Capacity (from Max to Min )", Value = "Capacity_DESC"} };

    }
}
