namespace SimpleTextEditor
{
    using System;
    using System.Collections.Generic;

    public class SimpleTextEditor
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var text = string.Empty;

            var versStack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var oper = int.Parse(line[0]);

                switch (oper)
                {
                    case 1:
                        versStack.Push(text);
                        text += line[1];
                        break;

                    case 2:
                        versStack.Push(text);
                        var length = text.Length - int.Parse(line[1]);
                        text = text.Substring(0, length);
                        break;

                    case 3:
                        var index = int.Parse(line[1]);
                        Console.WriteLine(text[index - 1]);
                        break;

                    case 4:
                        text = versStack.Pop();
                        break;
                }
            }
        }
    }
}
