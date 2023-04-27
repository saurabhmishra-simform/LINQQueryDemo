using System.Collections;

namespace OFType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentId = 1, StudentName = "Jimit" });

            var result = from s in mixedList.OfType<string>() select s;

            //OfType() method sysntex
            var resultMethod = mixedList.OfType<string>().ToList();

            foreach(var s in resultMethod)
            {
                Console.WriteLine(s);
            }
        }
    }
}