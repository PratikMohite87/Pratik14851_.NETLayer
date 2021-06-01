using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebPages.Models;

namespace RazorWebPages.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeService employeeService;
        [BindProperty]
        public Employee Employee { set; get; }

        public EditModel(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
                Employee = employeeService.GetEmployeeById(id.Value);
            else
                Employee = new Employee();

            if (Employee == null)
                return RedirectToPage("/NotFound");

            return Page();
        }

        public IActionResult OnPost(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (Employee.Id > 0)
                    Employee = employeeService.Update(employee);
                else
                    Employee = employeeService.Add(employee);

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
