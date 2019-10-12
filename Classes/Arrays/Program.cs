using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    // An array is an object !
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);  //Initialized zero
            Console.WriteLine(numbers[2]);

            bool[] flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);    //Initialized false
            Console.WriteLine(flags[2]);

            var names = new string[3] {"Suzane", "Mark", "Marie" };

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);    //Initialized empty
            Console.WriteLine(names[2]);

            Console.ReadLine();
        }
    }
}
