namespace FullDirectoryTraversal
{
    using System;
    using System.IO;
    using System.Linq;

    public class FullDirectoryTraversal
    {
        public static void Main()
        {
            var sourcePath = Console.ReadLine();

            var filePaths = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories);

            var files = filePaths.Select(path => new FileInfo(path)).ToList();

            var sortedFiles = files.OrderBy(f => f.Length)
                .GroupBy(f => f.Extension)
                .OrderByDescending(c => c.Count())
                .ThenBy(g => g.Key);

            var resultPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (var writer = new StreamWriter($"{resultPath}/report.txt"))
            {
                foreach (var group in sortedFiles)
                {
                    writer.WriteLine(group.Key);

                    foreach (var file in group)
                    {
                        writer.WriteLine($"--{file.Name} - {(file.Length / 1024.0):F3}kb");
                    }
                }
            }
        }
    }
}
