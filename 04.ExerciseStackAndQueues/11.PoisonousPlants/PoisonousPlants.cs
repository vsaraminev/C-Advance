namespace PoisonousPlants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PoisonousPlants
    {
        public static void Main(    )
        {
            int n = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

            var daysDie = new int[n];
            var plantsStack = new Stack<int>(new[] { 0 });

            for (int i = 1; i < n; i++)
            {
                int maxDays = 0;

                while (plantsStack.Count != 0 && plants[plantsStack.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, daysDie[plantsStack.Pop()]);
                }

                if (plantsStack.Count != 0)
                {
                    daysDie[i] = maxDays + 1;
                }
                plantsStack.Push(i);
            }

            Console.WriteLine(daysDie.Max());
        }
    }
}
