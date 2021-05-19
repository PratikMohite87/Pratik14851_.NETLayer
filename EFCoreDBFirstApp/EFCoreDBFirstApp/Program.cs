using EFCoreDBFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreDBFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MastekTrainingContext db = new MastekTrainingContext();
            //IEnumerable<Emp> empData = db.Emps.ToList();

            /*var empData = db.Emps.GroupBy(e => e.Job);

            foreach (var item in empData)
            {
                Console.WriteLine(item.Key);

                foreach (Emp emp in item)
                {
                    Console.WriteLine(emp.Ename);
                }
            }*/

            //Console.WriteLine(db.Emps.Sum(e => e.Sal));

            /*var empData = db.Emps.GroupBy(e => e.Deptno).Select(g => new { deptno = g.Key, tot = g.Sum(e => e.Sal) });
            foreach (var item in empData)
            {
                Console.WriteLine(item.deptno+" "+item.tot);
            }*/

            /*
            var empData = db.Emps.AsEnumerable().GroupBy(e => e.Deptno);
            foreach (var item in empData)
            {
                Console.WriteLine(item.Key);

                foreach (var subitem in item)
                {
                    Console.WriteLine(subitem.Ename);
                }
            }
            */

            var empData2 = from e in db.Emps
                           join d in db.Depts
                           on e.Deptno equals d.Deptno
                           select new { Ename = e.Ename, e.Job, e.Sal, DeptName = d.Dname };

            foreach (var item in empData2)
            {
                Console.WriteLine(item.Ename+" "+item.DeptName);
            }
                          
        }
    }
}
