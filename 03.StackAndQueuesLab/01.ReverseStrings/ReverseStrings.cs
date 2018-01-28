namespace ReverseStrings
{
    using System;
    using System.Collections.Generic;

    public class ReverseStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var characters = new Stack<char>();

            //var stack = new Stack<char>(input.ToCharArray());

            foreach (var ch in input)
            {
                characters.Push(ch);
            }

            while (characters.Count > 0)
            {
                Console.Write(characters.Pop());
            }

            Console.WriteLine();
        }
    }
}
