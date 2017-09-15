using System;

namespace Problem_06___Control_Number
{
    class ControlNumber
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNum = int.Parse(Console.ReadLine());

            var numOne = 0;
            var numTwo = 0;
            var sumOne = 0;
            var sumTwo = 0;
            var sumAll = 0;
            var realSum = 0;
            var combination = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    numOne = i;
                    numTwo = j;
                    sumOne = numOne * 2;
                    sumTwo = numTwo * 3;
                    sumAll = sumOne + sumTwo;
                    realSum += sumAll;
                    combination++;
                    if (realSum >= controlNum)
                    {
                        break;
                    }
                }
                if (realSum >= controlNum)
                {
                    break;
                }
            }
            if (realSum >= controlNum)
            {
                Console.WriteLine("{0} moves", combination);
                Console.WriteLine("Score: {0} >= {1}", realSum, controlNum);
            }
            else if (realSum < controlNum)
            {
                Console.WriteLine("{0} moves", combination);
            }
        }
    }
}
