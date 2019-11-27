using MyUniversityProject.Models.FilterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models.Pagination
{
    public class IndexUserViewModel
    {
        public List<UserInfo> UserInfo { get; set; }
        public UserFilterViewModel UserFilterViewModel { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
