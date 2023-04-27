using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystemWithLinq
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees;
            listEmployees= new List<Employee>()
            {
                new Employee {Id = 1,Name = "Ram", Salary = 500},
                new Employee {Id = 2,Name = "Kumar", Salary = 1000},
                new Employee {Id = 3,Name = "Jimit", Salary = 600},
                new Employee {Id = 4,Name = "Saurabh", Salary = 800},
                new Employee {Id = 5,Name = "Pavan", Salary = 400},
            };
            return listEmployees;
        }
    }
}
