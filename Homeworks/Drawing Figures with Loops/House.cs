﻿using System;

namespace House
{
    class House
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2 - i), new string('*', 1 + i * 2));  
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2 - i), new string('*', 2 + i * 2));
                }
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}
