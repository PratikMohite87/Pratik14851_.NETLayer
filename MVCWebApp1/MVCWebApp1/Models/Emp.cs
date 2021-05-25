using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MVCWebApp1.Models
{
    public partial class Emp
    {
        public Emp()
        {
            InverseMgrNavigation = new HashSet<Emp>();
        }

        [Required(ErrorMessage ="Field is required")]
        public int Empno { get; set; }
        [Required(ErrorMessage = "Field is required")]
        public string Ename { get; set; }
        public string Job { get; set; }
        public int? Mgr { get; set; }
        public DateTime? Hiredate { get; set; }
        public decimal? Sal { get; set; }
        public decimal? Comm { get; set; }
        public int? Deptno { get; set; }

        public virtual Dept DeptnoNavigation { get; set; }
        public virtual Emp MgrNavigation { get; set; }
        public virtual ICollection<Emp> InverseMgrNavigation { get; set; }
    }
}
