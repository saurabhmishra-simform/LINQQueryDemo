namespace LinqOperater
{
    public class Program
    {
        public static void Main()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                 new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                 new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                 new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                 new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                 new Student() { StudentID = 5, StudentName = "Ronn" , Age = 15 }
            };

            var studentResult = studentList.Where(a => a.StudentName.OfType<string>() != null).ToList();

            foreach(var res in studentResult)
            {
                Console.WriteLine(res.StudentName);
            }

            // LINQ Query Syntax to find out teenager student
            var teenStudent = from s in studentList
                              where (s.Age > 12 && s.Age < 20)
                              select s;
            Console.WriteLine("Teen age Students using Query syntex:");
            foreach (Student std in teenStudent)
            {
                Console.WriteLine($"StudentId={std.StudentID}\tStudentName={std.StudentName}\tStudentAge={std.Age}\t\n");
            }

            // LINQ Method Syntax to find out teenager student
            var teenStudent1 = studentList.Where(s => (s.Age > 12 && s.Age < 20));
            Console.WriteLine("Teen age Students using Method syntex:");
            foreach (Student std in teenStudent1)
            {
                Console.WriteLine($"StudentId={std.StudentID}\tStudentName={std.StudentName}\tStudentAge={std.Age}\t\n");
            }

            // LINQ Method Syntax using multiple para with where
            var teenStudent2 = studentList.Where((s, i) => (i % 2 == 0) && (s.Age > 12 && s.Age < 20));
            Console.WriteLine("LINQ Method Syntax using multiple para with where");
            foreach (Student std in teenStudent2)
            {
                Console.WriteLine($"StudentId={std.StudentID}\tStudentName={std.StudentName}\tStudentAge={std.Age}\t\n");
            }

            // LINQ Method Syntax using multiple where
            var teenStudent3 = studentList.Where(s => s.Age > 12).Where(s => s.Age < 20);
            Console.WriteLine("LINQ Method Syntax using multiple where");
            foreach (Student std in teenStudent3)
            {
                Console.WriteLine($"StudentId={std.StudentID}\tStudentName={std.StudentName}\tStudentAge={std.Age}\t\n");
            }

            // LINQ Method Syntax using Enumerable class  where
            var teenStudent4 = Enumerable.Where(studentList, s => s.Age > 12).Where(s => s.Age < 20);
            Console.WriteLine("LINQ Method Syntax using Enumerable class  where");
            foreach (Student std in teenStudent3)
            {
                Console.WriteLine($"StudentId={std.StudentID}\tStudentName={std.StudentName}\tStudentAge={std.Age}\t\n");
            }
        }
    }
}