namespace MaxSumSubmatrix
{
    using System;
    using System.Linq;

    public class MaxSumSubmatrix
    {
        public static void Main()
        {
            var matrixDimens = Console.ReadLine()
               .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int[,] matrix = new int[matrixDimens[0], matrixDimens[1]];

            var sum = 0;
            var rowIndex = 0;
            var columIndex = 0;

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

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int colum = 0; colum < matrix.GetLength(1) - 1; colum++)
                {
                    var currentSum = matrix[row, colum] + matrix[row, colum + 1] + matrix[row + 1, colum] + matrix[row + 1, colum + 1];

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        rowIndex = row;
                        columIndex = colum;
                    }
                }
            }

            Console.WriteLine($"{matrix[rowIndex, columIndex]} {matrix[rowIndex, columIndex + 1]}");
            Console.WriteLine($"{matrix[rowIndex + 1, columIndex]} {matrix[rowIndex + 1, columIndex + 1]}");

            Console.WriteLine(sum);
        }
    }
}
