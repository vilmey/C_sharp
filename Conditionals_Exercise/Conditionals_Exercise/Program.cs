using System;

namespace Conditionals_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            while (userInput != 23)
            {
                Console.Write("User, please type a number (1~10), 23 to exit:");
                userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(userInput);
                if (userInput < 1 || userInput > 10)
                    Console.WriteLine("Invalid input");
                else
                    Console.WriteLine("Valid");
            }
        }
    }
}
