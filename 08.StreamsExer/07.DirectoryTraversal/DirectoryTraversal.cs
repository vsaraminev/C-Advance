namespace DirectoryTraversal
{
    using System.IO;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DirectoryTraversal
    {
        public static void Main()
        {
            var path = Console.ReadLine();

            var files = Directory.GetFiles(path);

            var dictionary = new Dictionary<string, Dictionary<string, long>>();

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                var fileName = fileInfo.Name;

                var ext = fileInfo.Extension;

                var fileSize = fileInfo.Length;

                if (!dictionary.ContainsKey(ext))
                {
                    dictionary[ext] = new Dictionary<string, long>();
                }

                dictionary[ext].Add(fileName, fileSize);
            }

            dictionary = dictionary.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);            

            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var fullFileName = desktop + "/report.txt";

            using (var writer = new StreamWriter(fullFileName))
            {
                foreach (var ext in dictionary.OrderByDescending(x => x.Value.Count))
                {
                    writer.WriteLine($"{ext.Key}");

                    foreach (var file in ext.Value.OrderBy(x => x.Value))
                    {                        
                        writer.WriteLine($"--{file.Key} - {(double)(file.Value)/1000}kb");
                    }
                }
            }
        }
    }
}
