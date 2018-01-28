namespace BalancedParentheses
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class BalancedParentheses
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();

            var openCases = new char[] { '{', '[', '(' };

            for (int i = 0; i < input.Length; i++)
            {
                if (openCases.Contains(input[i]))
                {
                    stack.Push(input[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    switch (input[i])
                    {
                        case ')':
                            if (stack.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (stack.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case '}':
                            if (stack.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
