using System;

namespace Rhombus_of_Stars
{
    class RhombusOfStars
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}*", new string(' ', n - i));
                for (int k = 0; k < i - 1; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n; i++)
            {
                Console.Write("{0}*", new string(' ', i));
                for (int k = 1; k < n - i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
