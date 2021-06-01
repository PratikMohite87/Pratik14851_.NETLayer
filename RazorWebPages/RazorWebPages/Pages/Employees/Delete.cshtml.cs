using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebPages.Models;

namespace RazorWebPages.Pages.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly IEmployeeService employeeService;
        [BindProperty]
        public Employee Employee { set; get; }

        public DeleteModel(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public IActionResult OnGet(int id)
        {
            //if (id > 0)
            //{
            //    Employee = employeeService.GetEmployeeById(id);
            //}
            //else
            //{
            //    Employee = new Employee();
            //}

            //if (Employee == null)
            //    return RedirectToPage("/NotFound");

            //return Page();

            Employee = employeeService.GetEmployeeById(id);
            if (Employee != null)
            {
                return Page();
            }

            return RedirectToPage("/NotFound");
        }

        public IActionResult OnPost()
        {
            Employee deletedEmployee = employeeService.Delete(Employee.Id);

            if (deletedEmployee != null)
            {
                return RedirectToPage("Index");
            }

            return RedirectToPage("/NotFound");
        }
    }
}
