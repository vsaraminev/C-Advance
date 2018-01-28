namespace MatchingBrackets
{
    using System;
    using System.Collections.Generic;

    public class MatchingBrackets
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var bracketsStack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bracketsStack.Push(i);
                }

                if (input[i] == ')')
                {
                    var startIndex = bracketsStack.Pop();
                    var length = i - startIndex + 1;
                    Console.WriteLine(input.Substring(startIndex, length));
                }
            }
        }
    }
}
