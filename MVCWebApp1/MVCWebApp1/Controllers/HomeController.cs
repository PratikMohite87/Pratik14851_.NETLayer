using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCWebApp1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Greet/{data?}")]        // attribute route
        public IActionResult Greet(string data)
        {
            ViewBag.message = "Welcome " + data;
            //return Content("Welcome to ASP.NET");     // return the string format things only.
            return View();
        }

        // getdata?id-5     // query parameter way
        // getadata/5          // route parameter way
        public IActionResult GetData(int id)
        {
            ViewBag.message = "id = " + id;

            return View();
        }

        //[Route("Home/AddNumber/{first:int}/{second:int:range(1,10)}")]      // route constraint, we can put multiple constraint for single param using :
        [Route("[controller]/[action]/{first:int}/{second:int:range(1,10)}")]       // it will pickup the current controller name and current action name, it is called token, more generalised way.
        [HttpPost]      // will accept only post request.
        public IActionResult AddNumber(int first, int second)
        {
            ViewBag.result = "Addition is: " + (first + second);
            return View();
        }

        [Route("Home/ModelDemo/")]
        public IActionResult ModelDemo()
        {
            Employee emp = new Employee
            {
                EmployeeId = 1,
                EmployeeName = "Pratik",
                EmployeeSal = 10000
            };

            //ViewBag.emp = emp;
            ViewData["emp"] = emp;

            return View();
        }

        public IActionResult EmployeeForm()
        {
            return View(new Employee());
        }

        public IActionResult DisplayEmployeeData(Employee emp)
        {
            if (ModelState.IsValid)
            {
                return View(emp);
            }
            else
            {
                return View("EmployeeForm", emp);       // will ask to go to EmployeeForm method again with current emp object as parameter
            }
            
        }

        // changes
    }
}
