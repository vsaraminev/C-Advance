namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        public static void Main()
        {
            var softUniPath = "../Files/CopyMe.png";
            var resultPath = "result.png";

            using (var source = new FileStream(softUniPath, FileMode.Open))
            {
                using (var destination = new FileStream(resultPath, FileMode.Create))
                {
                    double fileLenght = source.Length;

                    var buffer = new byte[4096];

                    while (true)
                    {
                        var readBytes = source.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, buffer.Length);

                        Console.WriteLine("{0:P}", Math.Min(source.Position / fileLenght, 1));
                    }
                }
            }

            Console.WriteLine($"File \"{softUniPath}\" was copied to \"{resultPath}\".");
        }
    }
}
