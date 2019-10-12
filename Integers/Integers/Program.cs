using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num;
            int num2 = (int)26.9;
            try
            {
                num = Convert.ToByte(num2);
                Console.WriteLine(num);
            }
            catch (Exception)
            {
                Console.WriteLine("Num too large for conversion.");   
            }
            Console.ReadLine();
        }
    }
}
