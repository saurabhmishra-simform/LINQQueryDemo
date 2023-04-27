namespace LinqSyntex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> stringList = new List<string>()
            {
               "C# Tutorials",
               "F# Tutorials",
               "VB.Net Tutorials",
               "Learn C#",
            };
            var results = stringList.Where(s => s.Contains("C#"));

            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}