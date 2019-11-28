using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.FilterModel;
using MyUniversityProject.Models.StorageViewModel;
using System;
using System.Threading.Tasks;

namespace MyUniversityProject.Controllers
{
    public class StorageController : Controller
    {
        private readonly IStorageRepository _storageRepository;
        private readonly IStandartRepository _standartRepository;
        public StorageController(IStorageRepository storageRepository, IStandartRepository standartRepository)
        {
            _storageRepository = storageRepository;
            _standartRepository = standartRepository;
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
            var activeStorages = await _storageRepository.GetStorageInfoAsync(id);
            ViewBag.Filter = new CellFilterViewModel() { StorageId = id};

            return View("StorageInfo", activeStorages);
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpGet]
        public async Task<IActionResult> DeleteStorage(int id)
        {
            var result = await _storageRepository.DeleteAsync(id);
            TempData["ErrorMessage"] = result;
            return RedirectToAction(nameof(GetAllStorage));
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpPost]
        public async Task<IActionResult> StorageInformation(Storage storage)
        {
            if (!ModelState.IsValid)
                return View("StorageInfo", storage);

            var result = await _storageRepository.Update(storage);

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
            var result = await _storageRepository.CreateStorageAsync(storage);
            if (result != null)
            {
                ModelState.AddModelError("Error", result);
                return View(storage);
            }
            return RedirectToAction(nameof(GetAllStorage));
        }


        [Authorize(Roles = "Admin, SuperUser")]
        [HttpGet]
        public async Task<IActionResult> GetAllStorage(string currentFilter, string sortOrder, string searching)
        {
            var errMsg = TempData["ErrorMessage"];

            if (errMsg != null)
            {
                ModelState.AddModelError("", errMsg as string);
            }
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
            var activeStorages = await _storageRepository.GetAllStorageAsync(searching, sortOrder);

            return View(activeStorages);
        }

        /*--------------------CELL-------------------------*/

        [Authorize(Roles = "Admin ,SuperUser")]
        [HttpGet]
        public async Task<IActionResult> StorageCells([Bind("StorageId," +
            "MinWidth, MaxWidth, MinHeight, MaxHeight, MinLength, MaxLength, MinCapacity," +
            "MaxCapacity,SearchValue,SearchFilter,SortItem,FirstDate,SecondDate")]CellFilterViewModel cellFilterViewModel, int page=1)
        {
            var errMsg = TempData["ErrorMessage"];

            if (errMsg != null)
            {
                ModelState.AddModelError("", errMsg as string);
            }
            var storageCells = await _storageRepository.GetCellsAsync(cellFilterViewModel, page);
            return View(storageCells);
            
        }

        [Authorize(Roles = "Admin ,SuperUser")]
        [HttpGet]
        public async Task<IActionResult> GetAllCells([Bind("MinWidth," +
            "MaxWidth, MinHeight, MaxHeight, MinLength, MaxLength, MinCapacity," +
            "MaxCapacity,SearchValue,SearchFilter,SortItem")]CellFilterViewModel cellFilterViewModel, int page = 1)
        {
            var errMsg = TempData["ErrorMessage"];
            cellFilterViewModel.StorageId = -1;//кастыль что бы взять все ячейки
            if (errMsg != null)
            {
                ModelState.AddModelError("", errMsg as string);
            }
            var storageCells = await _storageRepository.GetCellsAsync(cellFilterViewModel, page);
            return View(nameof(StorageCells),storageCells);

        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpGet]
        public async Task<IActionResult> CreateCell()
        {
            CreateCellViewModel createCell = new CreateCellViewModel();
            createCell.Storages = await _storageRepository.GetStoragesAsync();
            createCell.Standarts = await _standartRepository.GetStandartsCellModelAsync();
            return View(createCell);
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpGet]
        public async Task<IActionResult> _DeleteCell(int storageId, int id, int page)
        {
            var result = await _storageRepository.DeleteCellAsync(id);
            TempData["ErrorMessage"] = result;
            return RedirectToAction(nameof(StorageCells), new { StorageId = storageId, page });
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpGet]
        public async Task<IActionResult> _DeleteOneCell(int id, int page)
        {
            var result = await _storageRepository.DeleteCellAsync(id);
            TempData["ErrorMessage"] = result;
            return RedirectToAction(nameof(GetAllCells), new { page });
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpPost]
        public async Task<IActionResult> CreateCell(CreateCellViewModel createCell)
        {
            if (!ModelState.IsValid)
            {
                return View(createCell);
            }
            var result = await _storageRepository.CreateCell(createCell);
            if (result != null)
            {
                ModelState.AddModelError("", result);
                return View(createCell);
            }
            return RedirectToAction(nameof(CreateCell));
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpGet]
        public async Task<IActionResult> GetCellInfo(int id)
        {
            var cellViewModel = await _storageRepository.GetCellViewModelAsync(id);
            cellViewModel.Standarts = await _standartRepository.GetStandartsCellModelAsync();

            return View(cellViewModel);
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpPost]
        public async Task<IActionResult> GetCellInfo(CreateCellViewModel updateCell)
        {
            if (!ModelState.IsValid)
                return View(updateCell);
            var result = await _storageRepository.UpdateCellViewModelAsync(updateCell);
            if (result != null)
            {
                ModelState.AddModelError("",result);
            }
            return View(updateCell);
        }


        /*--------------------STANDART-------------------------*/
        [Authorize(Roles = "Admin, SuperUser")]
        [HttpGet]
        public async Task<IActionResult> GetAllStandarts(string currentFilter, string sortOrder, string searching)
        {
            var errMsg = TempData["ErrorMessage"];

            if (errMsg != null)
            {
                ModelState.AddModelError("", errMsg as string);
            }

            ViewBag.MinVolume = String.IsNullOrEmpty(sortOrder) ? "minVolume" : "";
            ViewBag.MaxVolume = sortOrder == "MaxVolume" ? "maxVolume" : "MaxVolume";
            ViewBag.Price = sortOrder == "Price" ? "price" : "Price";

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
            var activeStorages = await _storageRepository.GetAllStorageAsync(searching, sortOrder);

            var model = await _standartRepository.GetStandartsAsync(searching, sortOrder);
            return View(model);
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpGet]
        public async Task<IActionResult> GetStandart(int id)
        {
            var model = await _standartRepository.GetStandartAsync(id);
            return View(model);
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpPost]
        public async Task<IActionResult> GetStandart(Standard standard)
        {
            if (!ModelState.IsValid)
                return View(standard);
            
            var result = await _standartRepository.UpdateStandartAsync(standard);
            if (result != null)
            {
                ModelState.AddModelError("", result);
            }
            return View(standard);
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpGet]
        public async Task<IActionResult> DeleteStandart(int id)
        {
            var result = await _standartRepository.DeleteStandartAsync(id);
            TempData["ErrorMessage"] = result;
            return RedirectToAction(nameof(GetAllStandarts));
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpPost]
        public async Task<IActionResult> _CreateStandart(Standard standard)
        {
            if (!ModelState.IsValid)
                return View(standard);
            var result = await _standartRepository.CreateStandartAsync(standard);
            if (result != null)
            {
                ModelState.AddModelError("Error", result);
                return View(standard);
            }
            return RedirectToAction(nameof(GetAllStandarts));
        }

        public async Task<IActionResult> _ChangeStandard(ChangeAllViewModel change)
        {
            if (!ModelState.IsValid)
                return View(change);

            var result = await _standartRepository.ChangeStandard(change);
            if (result != null)
            {
                ModelState.AddModelError("", result);
                return View("_ChangeStandard", change);
            }

            return View(nameof(GetStandart), new { id = change.OldId });
        }
    }
}