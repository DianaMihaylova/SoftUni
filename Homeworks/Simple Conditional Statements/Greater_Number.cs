using System;

namespace _04.Greater_Number
{
    class Greater_Number
    {
        static void Main()
        {
            Console.WriteLine("Enter two integers:");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Greater number: " + a);
            }
            else
            {
                Console.WriteLine("Greater number: " + b);
            }
        }
    }
}
