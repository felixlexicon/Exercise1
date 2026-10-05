using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Övning1
{
    internal class EmployeeRegister
    {
        private List<Employee> employees;

        public EmployeeRegister()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void ListEmployees()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
