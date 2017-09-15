using System;

namespace _08.Factorial
{
    class Factorial
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;
            do
            {
                num = num * n;
                n--;
            }
            while (n > 1);
            Console.WriteLine(num);
        }
    }
}
