using System;

namespace Triangle_of_Dollars
{
    class TriangleOfDollars
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write("$");
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
