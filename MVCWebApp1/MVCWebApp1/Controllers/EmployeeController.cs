using Microsoft.AspNetCore.Mvc;
using MVCWebApp1.Models;
using MVCWebApp1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp1.Controllers
{
    public class EmployeeController : Controller
    {
        MastekTrainingContext mastekTrainingContext;

        public EmployeeController(MastekTrainingContext context)
        {
            mastekTrainingContext = context;
        }
        //public IActionResult Index()
        //{
        //    return View(mastekTrainingContext.Emps.ToList());
        //}

        public IActionResult Index(string search)
        {
            var emps = from e in mastekTrainingContext.Emps select e;

            if (!String.IsNullOrEmpty(search))
            {
                emps = emps.Where(e => e.Ename.ToUpper().Contains(search.ToUpper()));
            }

            return View(emps.ToList());
        }

        public IActionResult Details(int id)
        {
            Emp emp = mastekTrainingContext.Emps.SingleOrDefault(e => e.Empno == id);

            if (emp == null)
            {
                return NotFound();
            }

            return View(emp);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Emp());
        }

        public IActionResult Create(Emp emp)
        {
            if (ModelState.IsValid)
            {
                mastekTrainingContext.Emps.Add(emp);
                mastekTrainingContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(emp);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //write linq query to check emp record by id
            //Emp emp1 = (Emp)(from e in db.Emps where e.Empno == id select e;
            Emp emp = mastekTrainingContext.Emps.SingleOrDefault(e => e.Empno == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);

        }

        [HttpPost]
        public IActionResult Delete(Emp emp)
        {
            if (emp.Empno > 0)
            {
                Emp searchemp = mastekTrainingContext.Emps.SingleOrDefault(e => e.Empno == emp.Empno);

                if (searchemp != null)
                {
                    mastekTrainingContext.Emps.Remove(searchemp);
                    mastekTrainingContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        //[HttpPost,ActionName("Delete")]
        //public IActionResult DeleteConfirm(int id)
        //{
        //    if(id > 0)
        //    {
        //        Emp searchemp = db.Emps.SingleOrDefault(e => e.Empno == id);

        //        if (searchemp != null)
        //        {
        //            db.Emps.Remove(searchemp);
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }

        //    }
        //    return View();
        //}

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //write linq query to check emp record by id
            //Emp emp1 = (Emp)(from e in db.Emps where e.Empno == id select e;
            Emp emp = mastekTrainingContext.Emps.SingleOrDefault(e => e.Empno == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Emp emp)
        {
            if (!mastekTrainingContext.Emps.Any(e => e.Empno == emp.Empno))
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                mastekTrainingContext.Update(emp);
                mastekTrainingContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public IActionResult EmpDeptData()
        {
            IEnumerable<EmptDeptViewModel> data = (from e in mastekTrainingContext.Emps.DefaultIfEmpty()
                                                   join d in mastekTrainingContext.Depts
                                                   on e.Deptno equals d.Deptno into ed
                                                   from de in ed.DefaultIfEmpty()
                                                   select new EmptDeptViewModel { Emp = e, Dept = de }).ToList();

            return View(data);
        }
    }
}
