﻿using System;

namespace Rectangle_of_N_x_N_Stars
{
    class RectangleOfNStars
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', n));
            }
        }
    }
}