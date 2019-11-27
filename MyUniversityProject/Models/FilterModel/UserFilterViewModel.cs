using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models.FilterModel
{
    public class UserFilterViewModel
    {
        public string SearchFilter { get; set; }
        public string SearchValue { get; set; }
        public string SortItem { get; set; }
        public int MinId { get; set; }
        public int MaxId { get; set; }

        public IEnumerable<SelectListItem> SearchParams => _searchParams;
        private readonly List<SelectListItem> _searchParams = new List<SelectListItem>
        {
            new SelectListItem { Text = "Any", Value = "Any" },
            new SelectListItem { Text = "Passport Id", Value = "PassportId" },
            new SelectListItem { Text = "Phone Number", Value = "PhoneNumber" },
            new SelectListItem { Text = "Last Name", Value = "LastName" },
            new SelectListItem { Text = "First Name", Value = "FirstName" },
            new SelectListItem { Text = "Address", Value = "Address" },
            new SelectListItem { Text = "Email", Value = "Email" },
            new SelectListItem { Text = "Reservation Id", Value = "ReserveId" },
            new SelectListItem { Text = "User Id", Value = "UserId" }
        };
        public IEnumerable<SelectListItem> SortList => _sortItems;
        private readonly List<SelectListItem> _sortItems = new List<SelectListItem>
        {
            new SelectListItem { Text = "Default", Value = "Default" },
            new SelectListItem { Text = "Last Name ASC", Value = "LastName_ASC" },
            new SelectListItem { Text = "Last Name DESC", Value = "LastName_DESC" },
            new SelectListItem { Text = "First Name ASC", Value = "FirstName_ASC" },
            new SelectListItem { Text = "First Name DESC", Value = "FirstName_DESC" },
            new SelectListItem { Text = "User Id ASC", Value = "UserId_ASC" },
            new SelectListItem { Text = "User Id DESC", Value = "UserId_DESC" }
        };
    }
}