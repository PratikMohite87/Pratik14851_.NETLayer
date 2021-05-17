using System;

namespace DataAccessLayerLib
{
    public class Emp
    {
        public int EmpNo { set; get; }
        public string EmpName { set; get; }
        public DateTime? HireDate { set; get; }
        public decimal? Salary { set; get; }

        public override string ToString()
        {
            return string.Format($"Empno = {EmpNo} EmpName = {EmpName} Hiredate = {HireDate} Salary = {Salary}");
        }
    }
}
