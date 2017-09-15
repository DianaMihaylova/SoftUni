using System;

namespace _02.Excellent_or_Not
{
    class Excellent_or_Not
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            if (a >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
