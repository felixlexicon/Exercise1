using System;
using System.Collections.Generic;
using System.Text;

namespace Övning1
{
    internal class Employee
    {
        public string Name { get; set; }
        public uint Salary { get; set; }

        public Employee(string name, uint salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}";
        }
    }
}
