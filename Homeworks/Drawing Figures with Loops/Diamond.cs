using System;

namespace Diamond
{
    class Diamond
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var innerDashes = 1;
            var innerDashesTwo = n - 4;
            var innerDashesThree = 2;

            if (n % 2 != 0)
            {
                Console.WriteLine("{0}*{0}", new string('-', n / 2));
                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 1) / 2 - i), new string('-', innerDashes));
                    innerDashes += 2;
                }
                for (int i = 1; i < (n - 1) / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', i), new string('-', innerDashesTwo));
                    innerDashesTwo -= 2;
                }
                if (n > 1)
                {
                    Console.WriteLine("{0}*{0}", new string('-', n / 2));
                }
            }
            else
            {
                Console.WriteLine("{0}**{0}", new string('-', n / 2 - 1));
                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 1) / 2 - i), new string('-', innerDashesThree));
                    innerDashesThree += 2;
                }
                for (int i = 1; i < (n - 1) / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', i), new string('-', innerDashesTwo));
                    innerDashesTwo -= 2;
                }
                if (n > 2)
                {
                    Console.WriteLine("{0}**{0}", new string('-', n / 2 - 1));
                }
            }
        }
    }
}
