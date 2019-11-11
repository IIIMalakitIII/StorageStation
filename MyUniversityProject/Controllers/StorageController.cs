using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyUniversityProject.IRepository;
using System;
using System.Threading.Tasks;

namespace MyUniversityProject.Controllers
{
    public class StorageController : Controller
    {
        private readonly IStorageRepository storageRepository;
        public StorageController(IStorageRepository storageRepository)
        {
            this.storageRepository = storageRepository;
        }

        [Authorize(Roles = "Admin ,SuperUser")]
        [HttpGet]
        public IActionResult Index()
        {
            //var activeStorages = await storageRepository.GetAllStorageAsync();
            return View();
        }

        //[Authorize(Roles = "Admin ,SuperUser")]
        //[HttpGet]
        //public async Task<IActionResult> AllStorage(string searching)
        //{
        //    if (searching == null)
        //    {
        //        searching = ""; 
        //    }
        //    var activeStorages = await storageRepository.GetAllStorageAsync(searching);
        //    return View(activeStorages);
        //}

        [Authorize(Roles = "Admin ,SuperUser")]
        [HttpGet]
        public async Task<IActionResult> AllStorage(string currentFilter, string sortOrder, string searching)
        {
            ViewBag.Status = String.IsNullOrEmpty(sortOrder) ? "status" : "";
            ViewBag.Location = sortOrder == "Location" ? "location" : "Location";



            if (searching == null)
            {
                if (currentFilter == null)
                {
                    searching = "";
                }
                else
                {
                    searching = currentFilter;
                }
            }

            ViewBag.CurrentFilter = searching;

            ViewData["DateSortParm"] = sortOrder == "Location" ? "location" : "Location";
            var activeStorages = await storageRepository.GetAllStorageAsync(searching, sortOrder);

            return View(activeStorages);
        }


        [Authorize(Roles = "Admin ,SuperUser")]
        [HttpGet]
        public async Task<IActionResult> ListOfCells(int id, int page=1)
        {

            var activeStorages = await storageRepository.GetCellsAsync(id, page);
            return View(activeStorages);
        }

    }
}