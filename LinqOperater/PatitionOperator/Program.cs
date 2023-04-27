namespace PatitionOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> students = new List<Student>()
            {
               new Student() {StudentId = 1, StudentName="Jimiy", Department="HR"},
               new Student() {StudentId = 2, StudentName="Abhishek", Department="IT"},
               new Student() {StudentId = 3, StudentName="Kumar", Department="Java"},
               new Student() {StudentId = 4, StudentName="Raju", Department="IT"},
            };

            //using take method
            IEnumerable<Student> takeResult = students.Take(2);
            foreach(Student student in takeResult)
            {
                Console.WriteLine("Student Id: {0} | Student Name: {1} | Department: {2}", student.StudentId, student.StudentName,student.Department);
            }
            Console.WriteLine("\n\n");

            //using skip method
            IEnumerable<Student> skipResult = students.Skip(3);
            foreach (Student student in skipResult)
            {
                Console.WriteLine("Student Id: {0} | Student Name: {1} | Department: {2}", student.StudentId, student.StudentName, student.Department);
            }
            Console.WriteLine("\n\n");

            //using take method
            IEnumerable<Student> takeWhileResult = students.TakeWhile(s=> s.StudentId > 2);
            foreach (Student student in takeWhileResult)
            {
                Console.WriteLine("Student Id: {0} | Student Name: {1} | Department: {2}", student.StudentId, student.StudentName, student.Department);
            }
            Console.WriteLine("\n\n");

            //using take method
            IEnumerable<Student> skipWhileResult = students.SkipWhile(s => s.StudentId == 2);
            foreach (Student student in takeWhileResult)
            {
                Console.WriteLine("Student Id: {0} | Student Name: {1} | Department: {2}", student.StudentId, student.StudentName, student.Department);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("Enter page number 1,2,3 and 4:");
            int pageNumber = 0;
            if(int.TryParse(Console.ReadLine(),out pageNumber))
            {
                if(pageNumber >= 1 && pageNumber <= 4)
                {
                    int pageSize = 3;
                    IEnumerable<Student> studentResult = students.Skip((pageNumber - 1) * pageSize).Take(pageSize);
                    Console.WriteLine();
                    Console.WriteLine("Displaying page: " + pageNumber);
                    foreach(Student student in studentResult)
                    {
                        Console.WriteLine(student.StudentId+ "\t" + student.StudentName + "\t" + student.Department);
                    }
                }
                else
                {
                    Console.WriteLine("Page number must be an integer between 1 and 4");
                }

            }
            else
            {
                Console.WriteLine("Page number must be an integer between 1 and 4");
            }
        }
    }
}