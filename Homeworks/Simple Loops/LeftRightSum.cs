using System;

namespace _07.Left_and_Right_Sum
{
    class LeftRightSum
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            for (int k = 0; k < n; k++)
            {
                var num = int.Parse(Console.ReadLine());
                rightSum += num;
            }
            var sum = Math.Abs(leftSum - rightSum);
            if (sum == 0)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + sum);
            }
        }
    }
}
