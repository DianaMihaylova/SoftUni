using System;

namespace _04.Even_Powers_of_2
{
    class EvenPowers
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;
            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(num);
                num *= 4;
            }
        }
    }
}
