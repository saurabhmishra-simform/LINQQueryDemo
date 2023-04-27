namespace DeferredExceution
{
    internal class Program
    {
        //This is one of the major advantages of deferred execution: it always gives you the latest data.
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

            IEnumerable<Employee> employees = listEmployee.Where(Emp => Emp.EmployeeId > 102);

            listEmployee.Add(new Employee() { EmployeeId = 106, EmployeeName = "Saurabh", Salary = 45000 });

            foreach (Employee employee in employees) //Query executed hear
            {
                Console.WriteLine("EmployeeId: {0} | EmployeeName: {1} | Salary: {2}", employee.EmployeeId, employee.EmployeeName, employee.Salary);
            }
        }
    }
}