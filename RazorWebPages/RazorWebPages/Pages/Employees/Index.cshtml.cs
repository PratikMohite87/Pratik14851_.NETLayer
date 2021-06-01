using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebPages.Models;

namespace RazorWebPages.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeService employeeService;
        public IEnumerable<Employee> Employees { set; get; }
        public IndexModel(IEmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }

        public void OnGet()
        {
            Employees = employeeService.GetAllEmployees();
        }
    }
}
