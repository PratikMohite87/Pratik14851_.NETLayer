using System;
using System.Collections.Generic;
using DataAccessLayerLib;

namespace DALApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Program().DisplayAllEmps();
            //Console.WriteLine("Finish");

            //int EmpNo = Convert.ToInt32(Console.ReadLine());
            //new Program().GetEmpDetail(EmpNo);

            Emp emp = new Emp();
            emp.EmpNo = Convert.ToInt32(Console.ReadLine());
            emp.EmpName = Console.ReadLine().ToString();
            emp.HireDate = Convert.ToDateTime(Console.ReadLine());
            emp.Salary = Convert.ToDecimal(Console.ReadLine());

            new Program().AddEmployeeDetail(emp);
        }

        EmpDataStore empDataStore;

        public Program()
        {
            empDataStore = new EmpDataStore(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MastekTraining;Integrated Security=True;");
        }

        void DisplayAllEmps()
        {
            List<Emp> empList = empDataStore.GetAllEmps();

            foreach (Emp emp in empList)
            {
                Console.WriteLine(emp);
            }
        }

        void GetEmpDetail(int EmpNo)
        {
            Emp emp = empDataStore.GetEmp(EmpNo);

            if (emp.EmpName != null)
            {
                Console.WriteLine(emp);
            }
            else 
            {
                Console.WriteLine("No Record Found");
            }
        }

        void AddEmployeeDetail(Emp emp)
        {
            if (empDataStore.AddEmp(emp) > 0)
                Console.WriteLine("data added successfully");
            else
                Console.WriteLine("Unsuccessful");
        }

        void UpdateEmployee(Emp emp)
        {
            Emp temp = empDataStore.GetEmp(emp.EmpNo);

            if (emp.EmpName == null)
                emp.EmpName = temp.EmpName;
            else if (emp.HireDate == null)
                emp.HireDate = temp.HireDate;
            else if (emp.Salary == null)
                emp.Salary = temp.Salary;

            if (empDataStore.UpdateEmp(emp) > 0)
                Console.WriteLine("data updated successfully");
            else
                Console.WriteLine("Unsuccessful");

        }

        void DeleteEmp(int EmpNo)
        {
            if (empDataStore.DeleteEmp(EmpNo) > 0)
                Console.WriteLine("data deleted successfully");
            else
                Console.WriteLine("Unsuccessful");
        }
    }
}
