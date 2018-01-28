namespace RecursiveFibonacci
{
    using System;

    public class RecursiveFibonacci
    {
        private static long[] fibNums;

        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());

            fibNums = new long[number];

            var result = GetFibonacci(number);

            Console.WriteLine(result);
        }

        public static long GetFibonacci(long number)
        {
            if (number <= 2)
            {
                return 1;
            }

            if (fibNums[number - 1] != 0)
            {
                return fibNums[number - 1];
            }

            return fibNums[number -1] = GetFibonacci(number - 1) + GetFibonacci(number - 2);
        }
    }
}
