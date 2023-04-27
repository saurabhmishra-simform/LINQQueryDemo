using DeferredExceution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredYield
{
    public static class EnumerableExtensionMethods
    {
        public static IEnumerable<Employee> GetEmployeeSaleryWise(this IEnumerable<Employee> employees)
        {
            foreach(Employee employee in employees)
            {
                if(employee.Salary == 44000)
                {
                    yield return employee;
                }
            }
        }
    }
}
