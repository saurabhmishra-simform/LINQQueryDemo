using LetorIntoKeyword;

namespace IntoKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            var studentResult = from s in studentList
                                where s.Age >18 && s.Age < 22
                                select s
                                into student
                                where student.StudentName.StartsWith("R")
                                select student;

            foreach (var student in studentResult)
            {
                Console.WriteLine(student.StudentName);
            }


        }
    }
}