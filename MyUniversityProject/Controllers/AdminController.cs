using System.Collections.Generic;
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

        public async Task<IActionResult> MyOffice()
        {
            var employee = await adminRepository.GetEpmloyee(User.Identity.Name);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [Authorize(Roles = "SuperUser")]
        [HttpPost]
        public async Task<IActionResult> UpdateSuperUser(Employee employee)
        {
            if (ModelState.IsValid)
            {
                adminRepository.UpdateEmployee(employee);
                try
                {
                    await adminRepository.SaveAsync();
                    if (await adminRepository.Check(User.Identity.Name, employee))
                    {
                        return RedirectToAction(nameof(MyOffice), "Admin");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Updating wasn't successful");
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("", "Updating to the database wasn't successful");
                }
            }
            return View("_MyOfficeForSuperUser", employee);
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpPost]
        public async Task<ActionResult> _ChangePassword([Bind("NewPassword, ConfirmPassword")]ChangePassword model)
        {
            if (ModelState.IsValid)
            {
                var changeUser = await adminRepository.UpdatePassword(User.Identity.Name, model);
                try
                {
                    await adminRepository.SaveAsync();
                    if (await adminRepository.Check(User.Identity.Name, changeUser))
                    {
                        return RedirectToAction(nameof(MyOffice), "Admin");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Updating user password wasn't successful");
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("", "Changing user password wasn't successful");
                }
            }
            //return CreatedAtAction("GetTaskInfo", new { id = taskItem.Id }, taskItem);
            return View("_ChangePassword", model);
        }


        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated && User.HasClaim(x => x.Type == ClaimTypes.Role
                    && x.Value == "Admin" || x.Value=="SuperUser"))
            {
                return RedirectToAction(nameof(MyOffice), "Admin");
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
                    return RedirectToAction(nameof(MyOffice), "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect login or password");
                }
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
    }
}