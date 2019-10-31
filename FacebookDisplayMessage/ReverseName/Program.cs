using System;

namespace ReverseName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello fella, type a name to be reversed !");
            var userInput = Console.ReadLine();
            var name = new char[userInput.Length];
            //Array.Reverse(name);
            for(int i = 0; i < userInput.Length; i++)
            {
                name[(userInput.Length - i)-1] = userInput[i];
            }

            Console.WriteLine(name);
        }
    }
}
