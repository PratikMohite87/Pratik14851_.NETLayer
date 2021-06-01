using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebPages.Models;

namespace RazorWebPages.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeService employeeService;

        public Employee Employee { set; get; }

        public DetailsModel(IEmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }

        public IActionResult OnGet(int id)
        {
            Employee = employeeService.GetEmployeeById(id);

            if (Employee == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }
    }
}
