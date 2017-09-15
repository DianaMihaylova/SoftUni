using System;

namespace _10.Number_100._._._200
{
    class Number_100_200
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            if (num <= 99)
            {
                Console.WriteLine("Less than 100");
            }
            else if (num <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (num > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
