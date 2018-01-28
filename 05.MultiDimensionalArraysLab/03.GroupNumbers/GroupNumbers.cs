namespace GroupNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var numBy0 = new List<int>();
            var numBy1 = new List<int>();
            var numBy2 = new List<int>();

            int[][] jaggedArr = new int[3][];

            foreach (var number in numbers)
            {
                if (Math.Abs(number) % 3 == 0)
                {
                    numBy0.Add(number);
                }
                else if (Math.Abs(number) % 3 == 1)
                {
                    numBy1.Add(number);
                }
                else if (Math.Abs(number) % 3 == 2)
                {
                    numBy2.Add(number);
                }
            }

            for (int row = 0; row < jaggedArr.Length; row++)
            {
                if (row == 0)
                {
                    jaggedArr[row] = new int[numBy0.Count];

                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        jaggedArr[row][col] = numBy0[col];
                    }
                }
                else if (row == 1)
                {
                    jaggedArr[row] = new int[numBy1.Count];

                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        jaggedArr[row][col] = numBy1[col];
                    }
                }
                else
                {
                    jaggedArr[row] = new int[numBy2.Count];

                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        jaggedArr[row][col] = numBy2[col];
                    }
                }
            }
            foreach (var row in jaggedArr)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
