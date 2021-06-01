using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemoApp.Shared;

namespace BlazorDemoApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<EmployeeModel> empList = new List<EmployeeModel>();

        public EmployeeController()
        {
            if (empList.Count == 0)
            {
                empList.Add(new EmployeeModel
                {
                    EmpNo = 1,
                    EmpName = "Pratik",
                    HireDate = Convert.ToDateTime("01/01/2001"),
                    Salary = 100000
                });

                empList.Add(new EmployeeModel
                {
                    EmpNo = 2,
                    EmpName = "Chinmay",
                    HireDate = Convert.ToDateTime("11/11/2011"),
                    Salary = 500000
                });
            }
        }

        [HttpGet]
        public IEnumerable<EmployeeModel> GetAllEmps()
        {
            return empList.ToArray();
        }

        [HttpPost]
        public void PostEmp(EmployeeModel employee)
        {
            empList.Add(employee);
        }
    }
}
