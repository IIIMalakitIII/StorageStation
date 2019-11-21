using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models.FilterModel
{
    public class ReserveFilterViewModel
    {
        [Display(Name = "Minimum price")]
        public decimal MinPrice { get; set; }

        [Display(Name = "Maximum price")]
        public decimal MaxPrice { get; set; }

        [Display(Name = "First Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FirstDate { get; set; }

        [Display(Name = "Second Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SecondDate { get; set; }

        public string SortItem { get; set; }

        public string SearchFilter { get; set; }
        public string SearchValue { get; set; }

        public IEnumerable<SelectListItem> SortList => _sortItems;
        private readonly List<SelectListItem> _sortItems = new List<SelectListItem> { new SelectListItem { Text = "Default", Value = "Default" },
                                                                                      new SelectListItem { Text = "From Min to Max Start Reserve Date", Value = "StartDate_ASC"},
                                                                                      new SelectListItem { Text = "From Max to Min Start Reserve Date", Value = "StartDate_DESC"},
                                                                                      new SelectListItem { Text = "From Min to Max End Reserve Date", Value = "EndDate_ASC"},
                                                                                      new SelectListItem { Text = "From Max to Min End Reserve Date", Value = "EndDate_DESC"},
                                                                                      new SelectListItem { Text = "Active First", Value = "Status_Active"},
                                                                                      new SelectListItem { Text = "Active Last", Value = "Status_Diactive"},
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

