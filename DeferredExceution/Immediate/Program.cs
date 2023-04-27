using DeferredExceution;

namespace Immediate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Employee> listEmployee = new List<Employee>()
            {
                new Employee() { EmployeeId = 101, EmployeeName = "Radheshyam", Salary = 45000 },
                new Employee() { EmployeeId = 102, EmployeeName = "Ramkumar", Salary = 23000 },
                new Employee() { EmployeeId = 103, EmployeeName = "Suresh", Salary = 44000 },
                new Employee() { EmployeeId = 104, EmployeeName = "Ramesh", Salary = 56000 },
                new Employee() { EmployeeId = 105, EmployeeName = "Ganesh", Salary = 44000 },
            };

            var employeeResult = listEmployee.OrderBy(x => x.Salary).ToList();

            listEmployee.Add(new Employee() { EmployeeId = 106, EmployeeName = "Jimit", Salary = 34000 });

            foreach(Employee emp in employeeResult)
            {
                Console.WriteLine("EmployeeId: {0} | EmployeeName: {1} | Salary: {2}", emp.EmployeeId, emp.EmployeeName, emp.Salary);
            }
        }
    }
}