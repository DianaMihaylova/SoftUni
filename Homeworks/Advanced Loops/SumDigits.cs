﻿using System;

namespace _09.Sum_Digits
{
    class SumDigits
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var sum = 0;
            do
            {
                sum = sum + (num % 10);
                num = num / 10;
            }
            while (num > 0);
            Console.WriteLine(sum);
        }
    }
}
