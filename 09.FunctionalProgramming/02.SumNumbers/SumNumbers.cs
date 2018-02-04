namespace SumNumbers
{
    using System;
    using System.Linq;

    public class SumNumbers
    {
        public static void Main()
        {
            var number = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            Console.WriteLine(number.Count());

            Console.WriteLine(number.Sum());
        }
    }
}
