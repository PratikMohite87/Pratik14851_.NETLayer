using MVCWebApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp1.ViewModels
{
    public class EmptDeptViewModel
    {
        public Emp Emp { set; get; }
        //public Dept Dept { set; get; }
        private Dept dept;

        private int years;
        private string salaryColor;

        public Dept Dept
        {
            set
            {
                if (value == null)
                {
                    dept = new Dept { Deptno = 0, Dname = "", Loc = "" };
                }
                else
                {
                    dept = value;
                }
            }

            get
            {
                return dept;
            }
        }

        public int Years
        {
            get
            {
                years = DateTime.Now.Year - Emp.Hiredate.Value.Year;
                return years;
            }
        }

        public string SalaryColor
        {
            get 
            {
                if (Emp.Sal.HasValue)
                {
                    if (Emp.Sal.Value > 2500)
                    {
                        salaryColor = "LightGreen";
                    }
                    else
                    {
                        salaryColor = "LightBlue";
                    }
                }
                else
                    salaryColor = "White";

                return salaryColor;
            }
        }
    }
}
