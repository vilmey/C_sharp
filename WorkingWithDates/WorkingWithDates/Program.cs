using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2019, 12, 12);

            Console.WriteLine("Year : " + dateTime.Year);
            Console.WriteLine("Current date: {0}", DateTime.Now.Year);

            var timeSpan = new TimeSpan(1, 0, 0);
            var timeSpan1 = TimeSpan.FromHours(1);
        }
    }
}
