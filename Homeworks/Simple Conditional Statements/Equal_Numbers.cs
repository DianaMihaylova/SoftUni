using System;

namespace _15._3_Equal_Numbers
{
    class Equal_Numbers
    {
        static void Main()
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());
            if (num1 == num2 && num1 == num3 && num2 == num3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
