using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemoApp.Shared
{
    public class EmployeeModel
    {
        [Required]
        public int? EmpNo { set; get; }
        [Required]
        public string EmpName { set; get; }
        [Required]
        public DateTime? HireDate { set; get; }
        [Required]
        public double? Salary { set; get; }
    }
}
