namespace BasicQueueOperation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicQueueOperation
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var elemToPop = input[1];

            var elemToCheck = input[2];

            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var numsQueue = new Queue<int>(numbers);

            for (int i = 0; i < elemToPop; i++)
            {
                if (numsQueue.Count > 0)
                {
                    numsQueue.Dequeue();
                }
            }

            bool isFound = numsQueue.Contains(elemToCheck);

            if (isFound)
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numsQueue.Count > 0)
                {
                    Console.WriteLine(numsQueue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
