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
        public DateTime FirstDate { get; set; }

        [Display(Name = "Second Date")]
        public DateTime SecondDate { get; set; }

        public string SortItem { get; set; }

        public string SearchFilter { get; set; }
        public string SearchValue { get; set; }

        public IEnumerable<SelectListItem> SortList => _sortItems;
        private readonly List<SelectListItem> _sortItems = new List<SelectListItem> { new SelectListItem { Text = "Default", Value = "Default" },
                                                                                      new SelectListItem { Text = "Date (from Min to Max)", Value = "Date_ASC"},
                                                                                      new SelectListItem { Text = "Date (from Max to Min)", Value = "Date_DESC"},
                                                                                      new SelectListItem { Text = "Status Active", Value = "Status_Active"},
                                                                                      new SelectListItem { Text = "Status Diactive", Value = "Status_Diactive"},
                                                                                      new SelectListItem { Text = "Price (from Min to Max)", Value = "Price_ASC" },
                                                                                      new SelectListItem { Text = "Price (from Max to Min)", Value = "Price_DESC" }};
        public IEnumerable<SelectListItem> SortListParams => _sortItemsParams;
        private readonly List<SelectListItem> _sortItemsParams = new List<SelectListItem> { new SelectListItem { Text = "Any", Value = "Any" },
                                                                                      new SelectListItem { Text = "Price", Value = "Price" },
                                                                                      new SelectListItem { Text = "Location", Value = "Location" },
                                                                                      new SelectListItem { Text = "Reservation Id", Value = "ReservationId" },
                                                                                      new SelectListItem { Text = "Location", Value = "Location" },
                                                                                      new SelectListItem { Text = "Cell Id", Value = "Cell_Id" }};
    }
}

