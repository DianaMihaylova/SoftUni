using System;

namespace _03.Powers_of_Two
{
    class PowersOfTwo
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                num *= 2;
            }
        }
    }
}
