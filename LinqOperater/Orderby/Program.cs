using System;

namespace Orderby
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

            //using query syntex
            var orderByResult = from s in students
                                orderby s.Department descending,s.StudentName ascending
                                select s;
            foreach (var student in orderByResult)
            {
                Console.WriteLine("StudentID: {0} | StudentName: {1} | Department: {2}", student.StudentId, student.StudentName, student.Department);
            }
            Console.WriteLine("\n\n");

            //using method sysntex
            IOrderedEnumerable<Student> orderByResults = students.OrderBy(s => s.StudentName);

            foreach ( var student in orderByResults )
            {
                Console.WriteLine("StudentID: {0} | StudentName: {1} | Department: {2}", student.StudentId,student.StudentName,student.Department);
            }
            Console.WriteLine("\n\n");

            //using orderByDesc method
            IOrderedEnumerable<Student> orderByDesc = students.OrderByDescending(s => s.Department);
            foreach (var student in orderByDesc)
            {
                Console.WriteLine("StudentID: {0} | StudentName: {1} | Department: {2}", student.StudentId, student.StudentName, student.Department);
            }
            Console.WriteLine("\n\n");

            //using ThenBy method
            IOrderedEnumerable<Student> thenByResult = students.OrderBy(s => s.StudentName).ThenBy(s => s.Department).ThenByDescending(s => s.StudentId);
            foreach (var student in thenByResult)
            {
                Console.WriteLine("StudentID: {0} | StudentName: {1} | Department: {2}", student.StudentId, student.StudentName, student.Department);
            }
            Console.WriteLine("\n\n");

            //using reverse method
            IEnumerable<Student> reverseResult = students.Reverse();
            foreach ( var student in reverseResult)
            {
                Console.WriteLine("StudentID: {0} | StudentName: {1} | Department: {2}", student.StudentId, student.StudentName, student.Department);
            }

        }
    }
}