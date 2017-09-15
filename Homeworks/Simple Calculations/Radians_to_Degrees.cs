using System;

namespace Radians_to_Degrees
{
    class Radians_to_Degrees
    {
        static void Main()
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * 180 / Math.PI;
            Console.WriteLine(Math.Round(deg));
        }
    }
}
