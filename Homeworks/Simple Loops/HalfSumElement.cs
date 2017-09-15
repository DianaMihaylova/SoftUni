using System;

namespace _10.Half_Sum_Element
{
    class HalfSumElement
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            var notHalfSum = Math.Abs((sum - max) - max);
            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", notHalfSum);
            }
        }
    }
}
