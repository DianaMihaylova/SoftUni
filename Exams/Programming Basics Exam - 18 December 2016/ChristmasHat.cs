using System;

namespace Problem_05.Christmas_Hat1
{
    class ChristmasHat
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}/|\\{0}", new string('.', n * 2 - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', n * 2 - 1));
            Console.WriteLine("{0}***{0}", new string('.', n * 2 - 1));
            var dotOut = n * 2 - 2;
            for (int i = 1; i <= n * 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dotOut), new string('-', i));
                dotOut--;
            }
            Console.WriteLine("{0}", new string('*', 4 * n + 1));
            for (int i = 1; i <= n * 2; i++)
            {
                Console.Write("*.");
            }
            Console.Write("*");
            Console.WriteLine();
            Console.WriteLine("{0}", new string('*', 4 * n + 1));
        }
    }
}
