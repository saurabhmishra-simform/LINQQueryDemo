namespace LetorIntoKeyword
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

            //without let variable
            /*var lowerCaseStudentName = from student in studentList
                                       where student.StudentName.ToLower().StartsWith("r") 
                                       select student;*/
            //using let variable
            var lowerCaseStudentName = from student in studentList
                                       let lowerCaseName = student.StudentName.ToLower()
                                       where lowerCaseName.StartsWith("r")
                                       select student;

            foreach (var student in lowerCaseStudentName)
            {
                Console.WriteLine(student.StudentName);
            }

        }
    }
}