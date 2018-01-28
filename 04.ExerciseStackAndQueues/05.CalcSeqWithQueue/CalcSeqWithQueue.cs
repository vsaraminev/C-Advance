namespace CalcSeqWithQueue
{
    using System;
    using System.Collections.Generic;

    public class CalcSeqWithQueue
    {
        public static void Main()
        {
            var startNum = long.Parse(Console.ReadLine());

            var numbers = new Queue<long>();

            numbers.Enqueue(startNum);

            for (int i = 0; i < 50; i++)
            {
                var currentNumber = numbers.Dequeue();

                Console.Write(currentNumber + " ");

                numbers.Enqueue(currentNumber + 1);

                numbers.Enqueue(currentNumber * 2 + 1);

                numbers.Enqueue(currentNumber + 2);
            }
        }
    }
}
