namespace SortEvenNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortEvenNumbers
    {
        public static void Main()
        {
            //var numbers = Console.ReadLine()
            //    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .Where(n => n % 2 == 0)
            //    .OrderBy(n => n)
            //    .ToList();

            var numbers = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var evenNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            evenNumbers = evenNumbers.OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ",evenNumbers));
        }
    }
}
