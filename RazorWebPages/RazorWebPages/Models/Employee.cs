using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorWebPages.Models
{
    public class Employee
    {
        public int Id { set; get; }
        [Required(ErrorMessage ="Name is required"), MinLength(3, ErrorMessage ="Name must contain atleast 3 character")]
        public string Name { set; get; }
        [Display(Name="Office Email")]
        [Required]
        public string Email { set; get; }
        [Required]
        public DeptOptions? Department { set; get; }
    }

    public enum DeptOptions
    {
        None,
        HR,
        IT,
        Payroll
    }
}
