using System.Diagnostics.CodeAnalysis;
using System.Linq;
namespace EmployeeSystemWithLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var results = Employee.GetAllEmployees().Where(employee => employee.Salary > 500).ToList();

            var results = from employee in Employee.GetAllEmployees() where employee.Salary > 500 select employee;

            foreach(var result in results)
            {
                Console.WriteLine("Id: {0} | Name: {1} | Salary: {2}",result.Id,result.Name,result.Salary);
            }
        }
    }
}