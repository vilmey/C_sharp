using System;
using System.Collections.Generic;

namespace UniqueNumbersList
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            var numbers = new List<int>();
            while(true)
            {
                Console.Write("Enter a number [\"Quit\" to exit]: ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(userInput));
            }

            numbers.Sort();
            var uniqueNum = new List<int>();
            foreach( var number in numbers)
            {
                if (!uniqueNum.Contains(number))
                    uniqueNum.Add(number);
            }

            Console.WriteLine("Unique numbers: ");
            foreach (var num in uniqueNum)
                Console.Write(num + ", ");
            
            Console.Write("\b \b");
            Console.Write("\b \b");
            
            Console.WriteLine();
        }
    }
}
