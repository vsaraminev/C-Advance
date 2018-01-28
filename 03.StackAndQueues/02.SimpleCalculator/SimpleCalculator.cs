namespace SimpleCalculator
{
    using System;
    using System.Collections.Generic;

    public class SimpleCalculator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var stack = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }

            while (stack.Count > 1)
            {
                var firstNum = int.Parse(stack.Pop());
                var oper = stack.Pop();
                var secondNum = int.Parse(stack.Pop());

                if (oper == "+")
                {
                    stack.Push((firstNum + secondNum).ToString());
                }
                else
                {
                    stack.Push((firstNum - secondNum).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
