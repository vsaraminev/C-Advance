namespace CountUppercaseWords
{
    using System;
    using System.Linq;

    public class CountUppercaseWords
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (var word in words)
            {
                if (char.IsUpper(word[0]))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
