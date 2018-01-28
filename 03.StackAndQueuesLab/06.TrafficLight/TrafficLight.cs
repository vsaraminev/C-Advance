namespace TrafficLight
{
    using System;
    using System.Collections.Generic;

    public class TrafficLight
    {
        public static void Main()
        {
            var carPass = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();

            var queue = new Queue<string>();

            var count = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    var passed = Math.Min(queue.Count, carPass);

                    for (int i = 0; i < passed; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
