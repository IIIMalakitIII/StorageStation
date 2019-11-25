﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.FilterModel;
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
            return View();
        }

        [Authorize(Roles="Admin, SuperUser")]
        [HttpGet]
        public async Task<IActionResult> StorageInformation(int id)
        {
            var activeStorages = await storageRepository.GetStorageInfoAsync(id);
            ViewBag.Filter = new CellFilterViewModel() { StorageId = id};

            return View("StorageInfo", activeStorages);
        }


        [Authorize(Roles = "Admin, SuperUser")]
        [HttpPost]
        public async Task<IActionResult> StorageInformation(Storage storage)
        {
            if (!ModelState.IsValid)
                return View("StorageInfo", storage);

            var result = await storageRepository.Update(storage);

            if (result !=null)
            {
                ModelState.AddModelError("", result);
                return View("StorageInfo", storage);
            }
            
            return View("StorageInfo", storage);
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpPost]
        public async Task<IActionResult> _CreateStorage(Storage storage)
        {
            if (!ModelState.IsValid)
                return View(storage);
            var result = await storageRepository.CreateStorageAsync(storage);
            if (result != null)
            {
                ModelState.AddModelError("Error", result);
                return View(storage);
            }
            return RedirectToAction(nameof(AllStorage));
        }


        [Authorize(Roles = "Admin, SuperUser")]
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
        public async Task<IActionResult> StorageCells([Bind("StorageId," +
            "MinWidth, MaxWidth, MinHeight, MaxHeight, MinLength, MaxLength, MinCapacity," +
            "MaxCapacity,SearchValue,SearchFilter,SortItem")]CellFilterViewModel cellFilterViewModel, int page=1)
        {
            var storageCells = await storageRepository.GetCellsAsync(cellFilterViewModel, page);
            return View(storageCells);
        }

        
    }
}