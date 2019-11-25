using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models.StorageViewModel
{
    public class CreateCellViewModel
    {
        public int CellId { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Length { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public bool Status { get; set; }
        public int StandardId { get; set; }
        public int StorageId { get; set; }

        public List<SelectListItem> Storages { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> Standarts { get; set; } = new List<SelectListItem>();
    }
}
