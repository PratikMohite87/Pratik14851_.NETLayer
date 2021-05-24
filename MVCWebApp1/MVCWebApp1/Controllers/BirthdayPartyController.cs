using Microsoft.AspNetCore.Mvc;
using MVCWebApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp1.Controllers
{
    public class BirthdayPartyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistrationForm()
        {
            return View(new Guest());
        }

        public IActionResult Acknowledgment(Guest guest)
        {
            if (ModelState.IsValid)
            {
                ViewBag.guest = guest;
                return View();
            }
            else
            {
                return View("RegistrationForm", guest);
            }
        }
    }
}
