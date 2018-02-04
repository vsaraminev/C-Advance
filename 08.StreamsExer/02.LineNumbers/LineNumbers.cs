namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            var file = "../Files/text.txt";

            using (var reader = new StreamReader(file))
            {
                var line = reader.ReadLine();

                var count = 1;

                while (line != null)
                {
                    Console.WriteLine($"Line {count}: {line}");

                    count++;

                    line = reader.ReadLine();
                }
            }
        }
    }
}
