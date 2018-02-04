namespace FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterByAge
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var inputName = input[0];

                var inputAge = int.Parse(input[1]);

                if (!dictionary.ContainsKey(inputName))
                {
                    dictionary[inputName] = 0;
                }

                dictionary[inputName] = inputAge;
            }

            var condition = Console.ReadLine();

            var age = int.Parse(Console.ReadLine());

            var formar = Console.ReadLine();

            if (condition == "younger")
            {
                dictionary = dictionary.Where(x => x.Value < age).ToDictionary(x => x.Key, y => y.Value);
            }
            else
            {
                dictionary = dictionary.Where(x => x.Value >= age).ToDictionary(x => x.Key, y => y.Value);
            }

            switch (formar)
            {
                case "name age":
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                    break;
                case "name":
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine($"{item.Key}");
                    }
                    break;
                case "age":
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine($"{item.Value}");
                    }
                    break;
            }
        }
    }
}
