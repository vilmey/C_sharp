using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Exe4();
        }

        static void Exe2()
        {
            var numList = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter numbers separated by hyphen: [Enter to Exit]");
                var userInput = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(userInput))
                    break;

                var numArray = userInput.Split('-');

                foreach (var number in numArray)
                {
                    if (numList.Contains(number))
                        Console.WriteLine("Duplicate! {0}", number);

                    else
                    {
                        Console.WriteLine("Number added to the list.");
                        numList.Add(number);

                        foreach (var num in numList)
                            Console.Write("{0} ", num);

                        Console.WriteLine();
                    }
                }
            }
        }

        static void Exe3()
        {
            while (true)
            {
                Console.WriteLine("Enter the time in 24 hour format: ");
                var userInput = Console.ReadLine();
                var timeParse = userInput.Split(':');
                if (Convert.ToInt32(timeParse[0]) > 23 || Convert.ToInt32(timeParse[0]) < 0)
                    Console.WriteLine("Invalid hour format.");

                if (Convert.ToInt32(timeParse[1]) > 59 || Convert.ToInt32(timeParse[1]) < 0)
                    Console.WriteLine("Invalid minute format.");
                //TimeSpan timeSpan = TimeSpan.Parse(userInput);
                //Console.WriteLine("Time {0}", timeSpan);
            }
        }

        static void Exe4()
        {
            while (true)
            {
                Console.WriteLine("Convert to PascalCase");
                Console.Write("Enter the name of the file: ");
                var userInput = Console.ReadLine();
                var parsedName = userInput.Split(' ');

                StringBuilder FileName = new StringBuilder();
                foreach (var name in parsedName)
                {
                    FileName.Append(name.Substring(0,1).ToUpper());
                    FileName.Append(name.Substring(1, name.Length -1).ToLower());
                }
                Console.WriteLine("The name we got: [{0}]", FileName);
            }
        }
    }
}
