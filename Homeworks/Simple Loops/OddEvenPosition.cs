using System;

namespace _11.Odd__Even_Position
{
    class OddEvenPosition
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var evenSum = 0.0;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;
            var oddSum = 0.0;
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;

            for (int i = 1; i < n + 1; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }
             Console.WriteLine("OddSum={0},", oddSum);
             Console.WriteLine("OddMin={0},", oddMin == double.MaxValue ? "No" : oddMin.ToString());
             Console.WriteLine("OddMax={0},", oddMax == double.MinValue ? "No" : oddMax.ToString());
             Console.WriteLine("EvenSum={0},", evenSum);
             Console.WriteLine("EvenMin={0},", evenMin == double.MaxValue ? "No" : evenMin.ToString());
             Console.WriteLine("EvenMax={0}", evenMax == double.MinValue ? "No" : evenMax.ToString());
        }
    }
}
