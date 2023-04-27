using System.Linq;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Saurabh", "Anand", "Sultanpur", "Ramesh", "Kumar" };
            var MyLinqQuery = from name in Names where name.Contains('a') orderby name ascending select name;

            foreach(var name in MyLinqQuery)
            {
                Console.WriteLine(name);
            }

        }
    }
}