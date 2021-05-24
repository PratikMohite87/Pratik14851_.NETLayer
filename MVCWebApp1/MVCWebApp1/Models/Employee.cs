using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCWebApp1.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Employee Id is required")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage ="Enter 4 digit employee id")]
        public int EmployeeId { set; get; }

        [Required(ErrorMessage ="Field is compulsory")]
        [StringLength(10, ErrorMessage ="Max length should be 10 characters")]
        public string EmployeeName { set; get; }

        [Required(ErrorMessage ="Salary required")]
        public int EmployeeSal { set; get; }
    }
}
