namespace HotPatato
{
    using System;
    using System.Collections.Generic;

    public class HotPatato
    {
        public static void Main()
        {

            var people = Console.ReadLine().Split(' ');

            var rotations = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(people);

            while (queue.Count > 1)
            {
                for (int i = 1; i < rotations; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
