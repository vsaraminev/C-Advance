namespace SlicingFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class SlicingFile
    {
        private const int bufferSize = 4096;

        private static List<string> files = new List<string>();

        public static void Main()
        {
            var sourceFile = "../Files/sliceMe.mp4";

            var destination = "";

            var parts = 5;

            Slice(sourceFile, destination, parts);            

            Assemble(files,destination);
        }

        public static void Slice(string sourceFile, string destDir, int parts)
        {
            using (var reader = new FileStream(sourceFile, FileMode.Open))
            {
                var ext = sourceFile.Substring(sourceFile.LastIndexOf('.') + 1);

                long pieceSize = (long)Math.Ceiling((double)reader.Length / parts);

                for (int i = 0; i < parts; i++)
                {
                    long currentPieceSize = 0;

                    if (destDir == string.Empty)
                    {
                        destDir = "./";
                    }

                    string currentPart = destDir + $"Part-{i}.{ext}";

                    files.Add(currentPart);

                    using (var writer = new FileStream(currentPart, FileMode.Create))
                    {
                        byte[] buffer = new byte[bufferSize];

                        while (reader.Read(buffer, 0, bufferSize) == 4096)
                        {
                            writer.Write(buffer, 0, bufferSize);

                            currentPieceSize += bufferSize;

                            if (currentPieceSize >= pieceSize)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void Assemble(List<string> files, string destDir)
        {
            var ext = files[0].Substring(files[0].LastIndexOf('.') + 1);

            if (destDir == string.Empty)
            {
                destDir = "./";
            }

            if (!destDir.EndsWith("/"))
            {
                destDir += "/";
            }

            string assFile = $"{destDir}Assembled.{ext}";

            using (var writer = new FileStream(assFile, FileMode.Create))
            {
                byte[] buffer = new byte[bufferSize];

                foreach (var file in files)
                {
                    using (var reader = new FileStream(file, FileMode.Open))
                    {
                        while (reader.Read(buffer, 0, bufferSize) == bufferSize)
                        {
                            writer.Write(buffer, 0, bufferSize);
                        }
                    }
                }
            }
        }
    }
}
