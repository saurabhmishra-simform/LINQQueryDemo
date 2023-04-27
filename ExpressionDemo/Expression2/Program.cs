using System.Linq;
using System.Linq.Expressions;

namespace Expression2
{
    internal class Program :Employee
    {
        static void Main(string[] args)
        {
            IList<Employee> employeesList = new List<Employee>()
            {
                new Employee() {Id=1,Name="Saurabh",Gender="Male"},
                new Employee() {Id=2,Name="Jimit",Gender="Male"},
                new Employee() {Id=3,Name="Mira",Gender="Female"},
                new Employee() {Id=4,Name="Ramesh",Gender="Male"},
                new Employee() {Id=5,Name="Shunaina",Gender="Female"},
            };

            //Expression<Func<string, bool>> expression = x => x.Id > 3 && x.Gender == "Male";

            //Func<string,bool> result = expression.Compile();

            var employes = employeesList.Where(x=> x.Id>1 && x.Gender=="Male").ToList();

            foreach(var emp in employes )
            {
                Console.WriteLine("Id: {0} | Name: {1}",emp.Id,emp.Name);
            }
        }
    }
}