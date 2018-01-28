namespace SumMathElements
{
    using System;
    using System.Linq;

    public class SumMathElements
    {
        public static void Main()
        {
            var matrixDimens = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixDimens[0], matrixDimens[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var numbers = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int colum = 0; colum < matrix.GetLength(1); colum++)
                {
                    matrix[row, colum] = numbers[colum];
                }
            }

            var sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int colum = 0; colum < matrix.GetLength(1); colum++)
                {
                    sum += matrix[row, colum];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
