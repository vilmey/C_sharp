using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Type a name that liked the post: ");
                var userInput = Console.ReadLine();
                if (userInput.Length == 0)
                    break;
                names.Add(userInput);
            }

            if (names.Count == 0)
                Console.WriteLine("Nobody liked our post yet.");
            else
            {
                if (names.Count == 1)
                    Console.WriteLine("{0} Likes your post.", names[0]);

                else if (names.Count == 2)
                {
                    Console.WriteLine("{0} and {1} Like your post.", names[0], names[1]);
                    
                }
                else
                {
                    Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count - 2);
                }
            }
        }
    }
}
