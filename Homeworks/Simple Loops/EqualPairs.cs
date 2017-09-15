using System;

namespace _12.Equal_Pairs
{
    class EqualPairs
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var prevSum = 0;
            var diff = 0;
            var maxDiff = 0;

            for (int i = 0; i < n; i++)
            {
                prevSum = sum;
                sum = 0;
                sum += int.Parse(Console.ReadLine());
                sum += int.Parse(Console.ReadLine());
                if (i != 0)
                {
                    diff = Math.Abs(sum - prevSum);
                    if (diff != 0 && diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
            }
            if (prevSum == sum || n == 1)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
