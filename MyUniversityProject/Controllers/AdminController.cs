using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.AuthenticationModel;
using MyUniversityProject.Models.StorageViewModel;

namespace MyUniversityProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminRepository adminRepository;
        public AdminController(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpGet]
        public async Task<IActionResult> AdminOffice()
        {
            var employee = await adminRepository.GetEpmloyee(User.Identity.Name);
            if (employee == null)
            {
                return RedirectToAction(nameof(Login));
            }

            return View(employee);
        }

        [Authorize(Roles = "SuperUser")]
        [HttpPost]
        public async Task<IActionResult> UpdateSuperUser(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var result = await adminRepository.UpdateEmployee(employee);
                if (result == null)
                {
                    return RedirectToAction(nameof(AdminOffice), "Admin");
                }
                ModelState.AddModelError("", "Updating user password wasn't successful");
                ModelState.AddModelError("", result);
            }

            return View("_OfficeForSuperUser", employee);
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpPost]
        public async Task<ActionResult> _ChangePassword([Bind("NewPassword, ConfirmPassword")]ChangePassword model)
        {
            if (ModelState.IsValid)
            {
                var result = await adminRepository.UpdatePassword(User.Identity.Name, model);
                if (result == null)
                {
                    return RedirectToAction(nameof(AdminOffice), "Admin");
                }
                ModelState.AddModelError("", "Updating user password wasn't successful");
                ModelState.AddModelError("", result);
            }

            return View(model);
        }


        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated && User.HasClaim(x => x.Type == ClaimTypes.Role
                    && x.Value == "Admin" || x.Value=="SuperUser"))
            {
                return RedirectToAction(nameof(AdminOffice), "Admin");
            }

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var Employeer = await adminRepository.Login(model);

                if (Employeer != null)
                {
                    await Authenticate(Employeer.Email,Employeer.Role);
                    return RedirectToAction(nameof(AdminOffice), "Admin");
                }

                ModelState.AddModelError("", "Incorrect Login or Password");
            }

            return View(model);
        }

        private async Task Authenticate(string userEmail, string role)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userEmail),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, role)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }


        [Authorize(Roles ="Admin, SuperUser")]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Login), "Admin");
        }

        [Authorize(Roles = "SuperUser")]
        [HttpGet]
        public IActionResult GetAdminDash()
        {
            return View(new SqlViewModel());
        }
        
        [Authorize(Roles = "SuperUser")]
        [HttpPost]
        public IActionResult GetAdminDash(SqlViewModel select)
        {
            var result = adminRepository.DashBoard(select);
            return View(result);
        }


        /*------------------Admins--------------------------*/


        [Authorize(Roles = "SuperUser")]
        [HttpGet]
        public async Task<IActionResult> GetAdmins(string currentFilter, string sortOrder, string searching)
        {

            var errMsg = TempData["ErrorMessage"];

            if (errMsg != null)
            {
                ModelState.AddModelError("", errMsg as string);
            }
            ViewBag.Id = String.IsNullOrEmpty(sortOrder) ? "id" : "";
            ViewBag.LastName = sortOrder == "LastName" ? "lastName" : "LastName";
            ViewBag.FirstName = sortOrder == "FirstName" ? "firstName" : "FirstName";

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
            ViewData["DateSortParm"] = sortOrder == "id" ? "id" : "Id";
            var activeStorages = await adminRepository.GetAdmins(sortOrder, searching);

            return View(activeStorages);
        }

        [Authorize(Roles = "SuperUser")]
        [HttpGet]
        public IActionResult CreateAdmin()
        {
            return View();
        }

        [Authorize(Roles = "SuperUser")]
        [HttpPost]
        public async Task<IActionResult> CreateAdmin(Employee employee)
        {
            if (!ModelState.IsValid)
                return View(employee);

            var result = await adminRepository.CreateAdmins(employee);
            if(result != null)
            {
                ModelState.AddModelError("", result);
                return View(employee);
            }
            return RedirectToAction(nameof(GetAdmins));
        }

        [Authorize(Roles = "SuperUser")]
        [HttpGet]
        public async Task<IActionResult> GetAdmin(int Id)
        {
            var result = await adminRepository.GetEpmloyee(Id);
            return View(result);
        }

        [Authorize(Roles = "SuperUser")]
        [HttpPost]
        public async Task<IActionResult> GetAdmin(Employee employee)
        {
            if (!ModelState.IsValid)
                return View(employee);

            var result = await adminRepository.UpdateAdmin(employee);

            if (result != null)
            {
                ModelState.AddModelError("", result);
                return View(employee);
            }

            return View(employee);
        }


        [Authorize(Roles = "SuperUser")]
        [HttpGet]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
                var result = await adminRepository.DeleteAdmin(id);
                TempData["ErrorMessage"] = result;
                return RedirectToAction(nameof(GetAdmins));
        }
    }
}