using System;

namespace Exe2_biggerNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("Num {0} is bigger than {1}", num1, num2);

            else
                Console.WriteLine("Num {0} is bigger than {1}", num2, num1);
        }
    }
}
