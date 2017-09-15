using System;

namespace Circle_Area_and_Perimeter
{
    class Circle_Area_and_Perimeter
    {
        static void Main()
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
