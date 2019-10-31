using System;

namespace Exe2_biggerNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the width  of the image:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the height of the image:");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
                Console.WriteLine("The image is in landscape mode {0}x{1}", width, height);

            else
                Console.WriteLine("The image is in portrait mode {0}x{1}", height, width);
        }
    }
}
