﻿using System;

namespace _14.Number_Table
{
    class NumberTable
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    var num = row + col + 1;
                    if (num > n)
                    {
                        num = 2 * n - num;
                    }
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
        }
    }
}