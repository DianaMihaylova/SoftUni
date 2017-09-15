using System;

namespace _10.Check_Prime
{
    class CheckPrime
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var prime = true;
            if (n < 2)
            {
                Console.WriteLine("Not prime");
            }
            for (var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            } 
        }
    }
}
