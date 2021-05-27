using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecurityDemoApp_2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityDemoApp_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<MyIdentityUser> userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<MyIdentityUser> userManager)
        {
            _logger = logger;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            MyIdentityUser user = userManager.GetUserAsync(HttpContext.User).Result;    // HttpContext is current request.

            ViewBag.Message = $"Welcome {user.FullName}";

            //ViewBag.Message = 

            if (userManager.IsInRoleAsync(user, "NormalUser").Result)
            {
                ViewBag.RoleMessage = "You are normal user.";
            }

            return View();
        }

        [Authorize(Roles = "admin")]
        public IActionResult OnlyAdminAccesss()
        {
            ViewBag.role = "Admin";

            MyIdentityUser user = userManager.GetUserAsync(HttpContext.User).Result;
            ViewBag.Message = $"Welcome {user.FullName}";

            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AllowAnonymous()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
