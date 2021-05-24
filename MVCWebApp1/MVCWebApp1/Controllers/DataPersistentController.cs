using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp1.Controllers
{
    public class DataPersistentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriteCookies(string setting, string settingValue, bool isPersistent)
        {
            if (isPersistent)
            {
                CookieOptions options = new CookieOptions();

                options.Expires = DateTime.Now.AddDays(1);

                Response.Cookies.Append(setting, settingValue, options);
            }
            else
            {
                Response.Cookies.Append(setting, settingValue);
            }

            ViewBag.Message = "Cookie Created successfully";

            return View("Index");
        }

        public IActionResult ReadCookies()
        {
            ViewBag.fontName = Request.Cookies["fontName"];
            ViewBag.fontSize = Request.Cookies["fontSize"];
            ViewBag.color = Request.Cookies["color"];

            if (string.IsNullOrEmpty(ViewBag.fontName))
                ViewBag.fontName = "Arial";

            if (string.IsNullOrEmpty(ViewBag.fontSize))
                ViewBag.fontSize = "22px";

            if (string.IsNullOrEmpty(ViewBag.color))
                ViewBag.color = "Black";

            return View();
        }
    }
}
