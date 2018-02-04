namespace OddLines
{
    using System;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            var file = "../Files/text.txt";

            using (var reared = new StreamReader(file))
            {
                var line = reared.ReadLine();

                var count = 0;

                while (line != null)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    count++;

                    line = reared.ReadLine();
                }
            }
        }
    }
}
