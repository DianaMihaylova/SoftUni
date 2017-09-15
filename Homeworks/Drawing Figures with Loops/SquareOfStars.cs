using System;

namespace Square_of_Stars
{
    class SquareOfStars
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
                for (int k = 1; k < n; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
