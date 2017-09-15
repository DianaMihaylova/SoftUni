using System;

namespace _06.Min_Number
{
    class MinNumber
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var n1 = int.Parse(Console.ReadLine());
            var min = n1;

            if (n > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    var num = int.Parse(Console.ReadLine());
                    if (num < min)
                    {
                        min = num;
                    }
                }
            }
            else
            {
                min = n1;
            }
            Console.WriteLine(min);
        }
    }
}
