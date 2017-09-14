using System;

namespace Square_of_Stars
{
    class Square_of_Stars
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            string stars = new string('*', n);
            Console.WriteLine(stars);
            for (int i = 1; i <= n - 2; i++)
            {
                string stars1 = "*" + new string(' ', n -2) + "*";
                Console.WriteLine(stars1);
            }
            string stars2 = new string('*', n);
            Console.WriteLine(stars2);
        }
    }
}
