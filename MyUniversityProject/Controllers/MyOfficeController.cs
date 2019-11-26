using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.AuthenticationModel;
using MyUniversityProject.Models.FilterModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using MyUniversityProject.Models.ErrorViewModel;
using System.Threading.Tasks;

namespace MyUniversityProject.Controllers
{
    public class MyOfficeController : Controller
    {

        private readonly IAccountRepository accountRepository;
        private readonly IReservationRepository reservationRepository;
        public MyOfficeController(IAccountRepository accountRepository, IReservationRepository reservationRepository)
        {
            this.accountRepository = accountRepository;
            this.reservationRepository = reservationRepository;
        }

        
        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> Index()
        {
            var user = await accountRepository.GetUser(User.Identity.Name);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }


        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated && User.HasClaim(x => x.Type == ClaimTypes.Role
        && x.Value == "User"))
            {
                return RedirectToAction(nameof(Index), "MyOffice");
            }

            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {

            if (ModelState.IsValid)
            {
                var User = await accountRepository.Login(model);

                if (User != null)
                {
                    await Authenticate(User.Email, User.Role);
                    return RedirectToAction(nameof(Index), "MyOffice");
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect login or password");
                }
            }

            return View(model);
        }


        [HttpGet]
        public ActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction(nameof(Index), "MyOffice");
            }

            return View();
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> _ReservationHistory([Bind("SearchFilter,SortItem,MinPrice,MaxPrice,SearchValue,FirstDate,SecondDate")] ReserveFilterViewModel reserveFilter, int page = 1)
        {
            if (User.Identity.IsAuthenticated)
            {
                int userId = await accountRepository.UserInfoId(User.Identity.Name);
                var list = await reservationRepository.GetUserReservations(userId, page, reserveFilter);
                return PartialView(list);
                //ViewBag.CurrentFilter = searching;

            }
            return RedirectToAction(nameof(Login));
        }


        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> ReservationHistory([Bind("SearchFilter,SortItem,MinPrice,MaxPrice,SearchValue,FirstDate,SecondDate")] ReserveFilterViewModel reserveFilter, int page = 1)
        {
            int userId = await accountRepository.UserInfoId(User.Identity.Name);
            var list = await reservationRepository.GetUserReservations(userId, page=1, reserveFilter);
            return View("ListOfReserve",list);
            //ViewBag.CurrentFilter = searching;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<UserInfo>> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                if (!accountRepository.UserExists(model.Email))
                {
                    await accountRepository.Registration(model);
                    try
                    {
                        await accountRepository.SaveAsync();
                        return RedirectToAction(nameof(Login), "MyOffice");
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        ModelState.AddModelError("", "Adding user to the database wasn't successful");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "A user with this login already exists.");
                }
            }
            return View(model);
        }


        
        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> _OfficeForUser(UserInfo user)
        {
            if (ModelState.IsValid)
            {
                var result = await accountRepository.UpdateAsync(user);
                if (result == null)
                {
                    return RedirectToAction(nameof(Index), "MyOffice");
                }
                
                ModelState.AddModelError("", result);
            }
            return View(user);
        }

        
        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> _ChangePassword(ChangePassword model)
        {
            if (ModelState.IsValid)
            {
                var result = await accountRepository.UpdatePassword(User.Identity.Name, model);
                if (result == null)
                {
                    return RedirectToAction(nameof(Index), "MyOffice");
                }

                ModelState.AddModelError("", result);
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


        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Login), "MyOffice");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}