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

            Console.ReadLine();

        }
    }
}
