using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MVCWebApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MVCWebApp1.Controllers
{
    public class DataPersistentController : Controller
    {

        public IConfiguration Configuration { get; }

        public DataPersistentController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public IActionResult Index()
        {
            ViewBag.data = Configuration["CustomerKey"];
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

        public IActionResult SessionDemo()
        {
            HttpContext.Session.SetString("message", "Session text");
            HttpContext.Session.SetInt32("count", 5);

            HttpContext.Session.SetString("dateObj", JsonSerializer.Serialize(DateTime.Now));

            Employee employee = new Employee
            {
                EmployeeId = 101,
                EmployeeName = "Pratik",
                EmployeeSal = 10000
            };

            HttpContext.Session.SetString("employee", JsonSerializer.Serialize(employee));

            return RedirectToAction("GetSession");
        }

        public IActionResult GetSession()
        {
            ViewBag.message = HttpContext.Session.GetString("message");
            ViewBag.count = HttpContext.Session.GetInt32("count");

            var dateObj = HttpContext.Session.GetString("dateObj");
            ViewBag.date = JsonSerializer.Deserialize<DateTime>(dateObj);

            ViewBag.employee = JsonSerializer.Deserialize<Employee>(HttpContext.Session.GetString("employee"));

            return View();
        }
    }
}
