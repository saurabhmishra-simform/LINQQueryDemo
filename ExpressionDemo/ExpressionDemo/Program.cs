using System.Linq.Expressions;

namespace ExpressionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listCity = new List<string>() { "Lucknow", "Vadodara", "Anand", "Ahemdabad", "Sultanpur" };

            //Func<string, bool> result= city => city.Contains("a");

            //Invoke Expression
            Expression<Func<string,bool>> res = city => city.Contains("d");

            //Expression<Action<string>> print = listCity => Console.WriteLine("City name found");
            //print.Compile();
            Func<string, bool> result = res.Compile();

            var myLinqQuery = listCity.FirstOrDefault(result);

            Console.WriteLine(myLinqQuery);
        }
    }
}