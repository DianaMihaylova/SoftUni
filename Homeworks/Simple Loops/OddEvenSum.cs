using System;

namespace _08.Odd_Even_Sum
{
    class OddEvenSum
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var evenSum = 0.00;
            var oddSum = 0.00;

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            var allSum = Math.Abs(evenSum - oddSum);
            if (allSum == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + allSum);
            }
        }
    }
}
