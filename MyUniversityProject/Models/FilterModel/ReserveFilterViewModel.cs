using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyUniversityProject.Models.FilterModel
{
    public class ReserveFilterViewModel
    {
        [Display(Name = "Minimum price")]
        public decimal MinPrice { get; set; }

        [Display(Name = "Maximum price")]
        public decimal MaxPrice { get; set; }

        [Display(Name = "First Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? FirstDate { get; set; }

        [Display(Name = "Second Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? SecondDate { get; set; }

        public string SortItem { get; set; }

        public string SearchFilter { get; set; }
        public string SearchValue { get; set; }

        public IEnumerable<SelectListItem> SortList => _sortItems;
        private readonly List<SelectListItem> _sortItems = new List<SelectListItem> { new SelectListItem { Text = "Default", Value = "Default" },
                                                                                      new SelectListItem { Text = "Start Reserve Date (from Min to Max)", Value = "StartDate_ASC"},
                                                                                      new SelectListItem { Text = "Start Reserve Date (from Max to Min )", Value = "StartDate_DESC"},
                                                                                      new SelectListItem { Text = "End Reserve Date (from Min to Max)", Value = "EndDate_ASC"},
                                                                                      new SelectListItem { Text = "End Reserve Date (from Max to Min )", Value = "EndDate_DESC"},
                                                                                      new SelectListItem { Text = "Price (from Min to Max)", Value = "Price_ASC" },
                                                                                      new SelectListItem { Text = "Price (from Max to Min)", Value = "Price_DESC" }};
        public IEnumerable<SelectListItem> SearchParams => _searchParams;
        private readonly List<SelectListItem> _searchParams = new List<SelectListItem> { new SelectListItem { Text = "Any", Value = "Any" },
                                                                                      new SelectListItem { Text = "Location", Value = "Location" },
                                                                                      new SelectListItem { Text = "Reservation Id", Value = "ReservationId" },
                                                                                      new SelectListItem { Text = "Location", Value = "Location" },
                                                                                      new SelectListItem { Text = "Status", Value = "Active"},
                                                                                      new SelectListItem { Text = "Cell Id", Value = "CellId" }};
    }
}

