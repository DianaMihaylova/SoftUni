﻿using System;

namespace Rectangle_Area
{
    class Rectangle_Area
    {
        static void Main()
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            var area = (a*b);
            Console.WriteLine(area);
        }
    }
}
