namespace AggreateFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringName = new List<string>() { "Saurabh", "Jimit", "Satyam", "Sanjay", "Pritesh" };
            string result = stringName.Aggregate((a, b) => a + "," + b);

            Console.WriteLine(result);
        }
    }
}