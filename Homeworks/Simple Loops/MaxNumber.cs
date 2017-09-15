using System;

namespace _05.Max_Number
{
    class MaxNumber
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var n1 = int.Parse(Console.ReadLine());
            var max = n1;

            if (n > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    var num = int.Parse(Console.ReadLine());
                    if (num > max)
                    {
                        max = num;
                    }
                }
            }
            else
            {
                max = n1;
            }
            Console.WriteLine(max);
        }
    }
}
