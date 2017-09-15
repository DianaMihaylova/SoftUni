using System;

namespace _05.Invalid_Number
{
    class Invalid_Number
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            if (!((num >= 100 && num <= 200) || num == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
