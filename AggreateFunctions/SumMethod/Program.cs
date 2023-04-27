namespace SumMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            int result = numbers.Aggregate((a, b) => a + b);

            IEnumerable<int> res = Enumerable.Where(numbers,a=>a>3).ToArray(); 

            foreach(int x in res)
            {
                Console.WriteLine(x);
            }
            //Console.WriteLine(result);
        }
    }
}