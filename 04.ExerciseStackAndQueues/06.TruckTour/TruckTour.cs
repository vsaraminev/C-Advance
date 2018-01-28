namespace TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TruckTour
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var currentPump = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                queue.Enqueue(currentPump);
            }

            for (int currentStart = 0; currentStart < n - 1; currentStart++)
            {
                var fuel = 0;
                bool isSolution = true;

                for (int pummpsPassed = 0; pummpsPassed < n; pummpsPassed++)
                {
                    var currentPump = queue.Dequeue();

                    var pumpFuel = currentPump[0];

                    var distanceToNextPump = currentPump[1];

                    queue.Enqueue(currentPump);

                    fuel += pumpFuel - distanceToNextPump;

                    if (fuel < 0)
                    {
                        currentStart += pummpsPassed;
                        isSolution = false;
                        break;
                    }
                    
                }

                if (isSolution)
                {
                    Console.WriteLine(currentStart);
                    return;
                }
            }
        }
    }
}
