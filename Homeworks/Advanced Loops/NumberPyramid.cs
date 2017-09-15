using System;

namespace _13.Number_Pyramid
{
    class NumberPyramid
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("{0} ", num++);
                    if (num > n)
                        break;
                }
                Console.WriteLine();
                if (num > n)
                    break;
            }
        }
    }
}
