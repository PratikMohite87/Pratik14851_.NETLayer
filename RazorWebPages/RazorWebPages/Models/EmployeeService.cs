using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorWebPages.Models
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        public Employee Update(Employee updateEmployee);
        public Employee Add(Employee newEmployee);
        public Employee Delete(int id);
    }
    public class EmployeeService : IEmployeeService
    {
        // all crud operation gets performed here 

        private List<Employee> employeeList;

        public EmployeeService()
        {
            employeeList = new List<Employee>();

            employeeList.Add(new Employee { Id = 1, Name = "bHAVANA", Email = "XYZZZ", Department = DeptOptions.HR });
            employeeList.Add(new Employee { Id = 2, Name = "bHAVANA1", Email = "XYZZZ1", Department = DeptOptions.IT });
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeList;
        }

        public Employee GetEmployeeById(int id)
        {
            //return employeeList.SingleOrDefault(e => e.Id == id);

            return (from e in employeeList where e.Id == id select e).SingleOrDefault();
        }

        public Employee Update(Employee updateEmployee)
        {
            //Employee employee = employeeList.FirstOrDefault(e => e.Id == updateEmployee.Id);
            //int index = employeeList.IndexOf(employee);

            //employeeList[index] = updateEmployee;

            //return employeeList[index];

            Employee employee = employeeList.FirstOrDefault(e => e.Id == updateEmployee.Id);
            if (employee != null)
            {
                employee.Name = updateEmployee.Name;
                employee.Email = updateEmployee.Email;
                employee.Department = updateEmployee.Department;
            }

            return employee;
        }

        public Employee Add(Employee newEmployee)
        {
            employeeList.Add(newEmployee);

            return employeeList.SingleOrDefault(e => e.Id == newEmployee.Id);
        }

        public Employee Delete(int id)
        {
            Employee employee = employeeList.SingleOrDefault(e => e.Id == id);
            employeeList.Remove(employee);

            return employee;
        }
    }
}
