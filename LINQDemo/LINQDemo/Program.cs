using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array - LINQtoObject
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /*foreach (int a in arr)
            {
                if (a % 2 == 0)
                    Console.WriteLine(a);
            }

            foreach (int a in arr)
            {
                Console.WriteLine(a*a);
            }*/

            // syntax for writing declarative Linq: from...where..select
            /*IEnumerable<int> eventData = from num in arr 
                                         where num % 2 == 0 
                                         select num;*/

            // method Linq
            //IEnumerable<int> eventData = arr.Where(num => num % 2 == 0);

            /*IEnumerable<int> eventData = from num in arr
                                         select num * num;*/

            //IEnumerable<int> eventData = arr.Select(num => num*num);

            /*foreach (int value in eventData)
            {
                Console.Write(value+" ");
            }*/
            #endregion

            #region Extensionmethods
            //string str = "hello hdhshd hdhdhf hfhfhf";
            //Console.WriteLine(str.wordCount());
            #endregion

            #region Generic Collection - LINQtoObject

            // collection initilizer
            List<Employee> empList = new List<Employee>()
            {
                //object initializer
                new Employee { EmpName="bhavana", Address="mumbai", Department="accounts", Salary=15000},
                new Employee { EmpName="vishal", Address="pune", Department="sales", Salary=18000},
                new Employee { EmpName="kavita", Address="mumbai", Department="sales", Salary=25000},
                new Employee { EmpName="amit", Address="mumbai", Department="accounts", Salary=20000},
                new Employee { EmpName="hemant", Address="pune", Department="sales", Salary=27000},
                new Employee { EmpName="aarti", Address="pune", Department="accounts", Salary=30000},
                new Employee { EmpName="varsha", Address="mumbai", Department="accounts", Salary=15000}
            };

            #region defferred execution - query is not executed at line 65 or 69, its get executed at line 71 i.e when o/p is required
            /*IEnumerable<Employee> eventData = from emp in empList
                                              where emp.Address == "mumbai"
                                              select emp;

            IEnumerable<Employee> eventData2 = empList.Where(emp => emp.Address == "mumbai");

            foreach (Employee emp in eventData2)
                Console.WriteLine(emp);*/
            #endregion

            #region Immediate execution
            /*
            IEnumerable<Employee> eventData3 = (from emp in empList
                                                where emp.Address == "mumbai"
                                                select emp).ToList();     // due to addition of tolist() your query will get executed here only not when you use empData3.

            IEnumerable<Employee> eventData4 = empList.Where(emp => emp.Address == "mumbai").ToList();
            */
            #endregion

            #region First(), FirstorDefault(), Single(), SingleorDefault()
            /*
            Employee emp = (from e in empList where e.EmpName == "vishal" select e).First();        // will give 1st found record only
            Employee emp2 = (from e in empList where e.EmpName == "vishal" select e).FirstOrDefault();       // if not even single redord is present satisfying the condition then it will return null.
            Employee emp3 = (from e in empList where e.EmpName == "vishal" select e).Single();      // will return the single record present, if more than one record present the will throw exception.

            Employee emp4 = empList.Where(e => e.EmpName == "vishal").Single();
            Employee emp5 = empList.Single(e => e.EmpName == "vishal");
            Employee emp6 = empList.Where(e => e.EmpName == "vishal").SingleOrDefault();
            */
            #endregion

            var emp = from e in empList
                      where e.Salary > 1000
                      select new { e.EmpName, job = e.Department, e.Salary };

            var emp2 = empList.Where(e => e.Salary > 1000).Select(e => new { e.EmpName, job = e.Department, e.Salary });

            foreach (var item in emp)
                Console.WriteLine(item.EmpName+" "+item.job+" "+item.Salary+" "+item.GetType().Name);

            #endregion
        }
    }
}
