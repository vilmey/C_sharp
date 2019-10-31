using System;
using System.Collections.Generic;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> ();
            string userInput;
            while(true)
            {
                Console.Write("Please type a number: ");
                userInput = Console.ReadLine();
                if (numbers.Contains(Convert.ToInt32(userInput)) == true)
                    Console.WriteLine("The number is already on the list.");
                else
                    numbers.Add(Convert.ToInt32(userInput));
                if (numbers.Count == 5)
                    break;
            }
            Console.WriteLine("\nAntes de Numbers.Sort() : ");
            foreach (var number in numbers)
                Console.Write(number + ", ");

            Console.Write("\b \b");
            Console.Write("\b \b");

            numbers.Sort();
            Console.WriteLine("\nNumbers.Sort() : ");
            foreach (var number in numbers)
                Console.Write(number + ", ");

            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.WriteLine();
        }
    }
}
