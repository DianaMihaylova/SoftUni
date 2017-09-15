using System;

namespace _12.Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var fibFirst = 1;
            var fibSecond = 1;
            var fibsum = 0;

            if (n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    fibsum = fibFirst + fibSecond;
                    fibFirst = fibSecond;
                    fibSecond = fibsum;
                }
                Console.WriteLine(fibsum);
            }
        }
    }
}
