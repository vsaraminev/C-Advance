namespace AddVAT
{
    using System;
    using System.Linq;

    public class AddVAT
    {
        public static void Main()
        {
            var prices = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price*1.2:f2}");
            }
        }
    }
}
