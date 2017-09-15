using System;

namespace _05.Fox
{
    class Fox
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var innerDashes = (n * 2) - 1;
            var innFigure = n;
            var innFigureTwo = (n * 2) - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', i), new string('-', innerDashes));
                innerDashes -= 2;
            }
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n / 2 + i), new string('*', innFigure));
                innFigure -= 2;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', i), new string('*', innFigureTwo));
                innFigureTwo -= 2;
            }
        }
    }
}
