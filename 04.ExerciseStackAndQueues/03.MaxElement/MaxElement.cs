namespace MaxElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxElement
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numStack = new Stack<int>();

            var maxNumStack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var command = input[0];

                switch (command)
                {
                    case 1:
                        var number = input[1];

                        numStack.Push(number);

                        if (maxNumStack.Count == 0 || maxNumStack.Peek() < number)
                        {
                            maxNumStack.Push(number);
                        }
                        break;
                    case 2:
                        if (numStack.Count > 0)
                        {
                           var elemToRem = numStack.Pop();

                            if (maxNumStack.Count != 0 && maxNumStack.Peek() == elemToRem)
                            {
                                maxNumStack.Pop();
                            }
                        }
                        break;
                    case 3:
                        if (maxNumStack.Count > 0)
                        {
                            Console.WriteLine(maxNumStack.Peek());
                        }
                        break;
                }               
            }
        }
    }
}
