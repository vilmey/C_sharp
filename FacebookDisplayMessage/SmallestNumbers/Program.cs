using System;
using System.Collections.Generic;

namespace SmallestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            string[] NumberSplit;
            while(true)
            {
                Console.Write("Enter a list of numbers separated by comma: ");
                var userInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    NumberSplit = userInput.Split(",");
                    if (NumberSplit.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid List");
            }

            foreach (var Number in NumberSplit)
            {
                if (!numbers.Contains(Convert.ToInt32(Number)))
                    numbers.Add(Convert.ToInt32(Number));
            }

            numbers.Sort();
            foreach (var element in numbers)
                Console.WriteLine(element);

            Console.Write("3 smallest numbers {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
        }
    }
}
