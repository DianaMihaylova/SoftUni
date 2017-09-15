using System;

namespace Celsius_to_Fahrenheit
{
    class Celsius_to_Fahrenheit
    {
        static void Main()
        {
            var c = double.Parse(Console.ReadLine());
            var f = c * 1.8 + 32;
            Console.WriteLine(Math.Round(f, 2));
        }
    }
}
