using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Employee
    {
        public string EmpName { set; get; }
        public string Address { set; get; }
        public string Department { set; get; }
        public decimal Salary { set; get; }

        public override string ToString()
        {
            return string.Format($"Name = {EmpName} Address = {Address} Department = {Department} Salary = {Salary}");
        }
    }
}
