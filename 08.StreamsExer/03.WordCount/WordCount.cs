namespace WordCount
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        public static void Main()
        {
            var textFile = "../Files/text.txt";

            var wordsFile = "../Files/words.txt";

            var wordsList = new List<string>();

            var result = new Dictionary<string, int>();

            using (var reader = new StreamReader(textFile))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    var words = line
                        .Split(new[] { ' ', ',', '-', '\'', '.', '!', '?' }, System.StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    foreach (var word in words)
                    {
                        wordsList.Add(word.ToLower());
                    }

                    line = reader.ReadLine();
                }
            }

            using (var reader = new StreamReader(wordsFile))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    foreach (var word in wordsList)
                    {
                        if (word == line)
                        {
                            if (!result.ContainsKey(line))
                            {
                                result[line] = 0;
                            }

                            result[line]++;
                        }
                    }

                    line = reader.ReadLine();
                }
            }

            using (var writer = new StreamWriter("result.txt"))
            {
                foreach (var word in result.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
