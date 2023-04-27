namespace Selectmany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "abcdefghijklmnopqrstwxyz", "0123456789" };

            // Student collection
            IList<Student> studentList = new List<Student>() {
                 new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                 new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                 new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                 new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                 new Student() { StudentID = 5, StudentName = "Ronn" , Age = 15 }
            };
            //using method syntex
            IEnumerable<char> result = stringArray.SelectMany(x => x);

            //using query syntex
            IEnumerable<char> resultQuery = from s in stringArray
                                            from c in s
                                            select c;

            var resultStudent = studentList.Select(x => x.StudentName).ToList();

            var listName = studentList.SelectMany(x => x.StudentName).ToList();
  
            foreach(var r in listName)
            {
                Console.WriteLine(r);
            }
        }
    }
}