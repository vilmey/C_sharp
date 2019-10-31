using System;

namespace Exe4_speedCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("What is the speed limit (km/h) ?:");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.Write("What is the vehicle speed (km/h) ?:");
                int vehicleSpeed = Convert.ToInt32(Console.ReadLine());

                if (speedLimit >= vehicleSpeed)
                    Console.WriteLine("OK");
                else
                {
                    int infraction = (vehicleSpeed - speedLimit) / 5;
                    if (infraction < 12)
                        Console.WriteLine("Points: {0}", infraction);
                    else
                        Console.WriteLine("Suspended: points {0}", infraction);

                }
            }
        }
    }
}
