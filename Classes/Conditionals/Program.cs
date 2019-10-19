using System;

namespace Conditionals
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var season = Seasons.Autumn;

            switch(season)
            {
                case Seasons.Autumn:
                    Console.WriteLine("Its autumn, and a beautifull season.");
                    break;

                case Seasons.Spring:
                    Console.WriteLine("Its spring.");
                    break;

                case Seasons.Summer:
                    Console.WriteLine("Its not winter yet.");
                    break;

                case Seasons.Winter:
                    Console.WriteLine("The winter is here !!!!");
                    break;

                default:
                    Console.WriteLine("I don't understand that season.");
                    break;
            }
        }
    }
}
