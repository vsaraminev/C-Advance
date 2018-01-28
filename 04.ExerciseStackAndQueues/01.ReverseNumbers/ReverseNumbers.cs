namespace ReverseNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                   .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse);

            var numStack = new Stack<int>(numbers);

            while (numStack.Count > 0)
            {
                Console.Write($"{numStack.Pop()} ");
            }

            Console.WriteLine();
        }
    }
}
