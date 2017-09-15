using System;

namespace Triangle_Area
{
    class Triangle_Area
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = a * h / 2;
            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
