using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayerLib;
using Microsoft.Extensions.Configuration;

namespace MVCWebApp1.Controllers
{
    public class DalController : Controller
    {
        EmpDataStore empDataStore = null;
        public IConfiguration Configuration { get; }

        public DalController(IConfiguration config, EmpDataStore empData)
        {
            Configuration = config;
            empDataStore = empData;
            string conStr = Configuration["ConnectionStrings:MyDBConnection"];
            empDataStore.SetConnection(conStr);

        }
        public IActionResult Index()
        {
            List<Emp>  empList = empDataStore.GetAllEmps();

            return View(empList);
        }
    }
}
