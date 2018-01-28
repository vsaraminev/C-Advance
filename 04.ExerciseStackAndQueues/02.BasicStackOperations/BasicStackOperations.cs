namespace BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicStackOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var elemToPop = input[1];

            var elemToCheck = input[2];

            var numStack = new Stack<int>(numbers);

            for (int i = 0; i < elemToPop; i++)
            {
                numStack.Pop();
            }

            if (numStack.Any())
            {
                bool IsFound = numStack.Contains(elemToCheck);

                if (IsFound)
                {
                    Console.WriteLine("true");
                }
                else
                {                    
                    Console.WriteLine(numStack.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
            
        }
    }
}
