namespace StackFibonacci
{
    using System;
    using System.Collections.Generic;

    public class StackFibonacci
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());

            var fibStack = new Stack<long>(new[] { 0, 1L });

            for (int i = 0; i < number - 1; i++)
            {
                var firstPrevNum = fibStack.Pop();

                var secondPrevNum = fibStack.Peek();

                fibStack.Push(firstPrevNum);

                fibStack.Push(firstPrevNum + secondPrevNum);
            }

            Console.WriteLine(fibStack.Pop());
        }
    }
}
