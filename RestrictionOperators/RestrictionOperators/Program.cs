namespace RestrictionOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //IEnumerable<int> evenNumbers = numbers.Where(num => num % 2 == 0);

            /*IEnumerable<int> evenNumbers = from num in numbers
                                           where num % 2 == 0
                                           select num;*/
            var result = numbers
                .Select((num, index) => new { Number = num, Index = index })
                .Where(x => x.Number % 2 == 0)
                .Select(x => x.Index);

            //foreach(int num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}