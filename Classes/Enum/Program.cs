using System;

namespace Enum_
{
    public enum ShippingMethod
    {
        RegularAirmail = 1,
        RegisteredAirmail = 2,
        Express = 3
    }

    class Program
    {
        public class Point
        {
            public int a;
            public int b;
            public static int sum(int x, int y)
            {
                return x + y;
            }
        }

        static void Main(string[] args)
        {
            var Method = ShippingMethod.Express;
            Console.WriteLine((int)Method);             //Output the number

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);    //Output the string
            Console.WriteLine(Method.ToString());           //Output the string as well

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName); //Converts the String to the enum type
            Console.WriteLine(shippingMethod);
            int[] numbers = new int[3];

            //We don't need an instance of Point to access a public static function (method)
            //A static function will be the same for all the childs, this function will not be
            //replicated
            Console.WriteLine("Testing a static method inside a class\nThe sum of 10 + 13 = {0}", Point.sum(10, 13));

            //Creating an instance of point, and giving numbers to its atribbutes   
            Point instance_of_point = new Point
            {
                a = 10,
                b = 20
            };

            Console.WriteLine(String.Format("A = {0}, B = {1}", instance_of_point.a, instance_of_point.b));
            
            Console.ReadLine();

        }
    }
}
