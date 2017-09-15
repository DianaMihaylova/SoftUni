using System;

namespace _06.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int numOne = 1; numOne < 10; numOne++)
            {
                for (int numTwo = 1; numTwo < 10; numTwo++)
                {
                    for (int numThree = 1; numThree < 10; numThree++)
                    {
                        for (int numFour = 1; numFour < 10; numFour++)
                        {
                            if (n % numOne == 0 && n % numTwo == 0 && n % numThree == 0 && n % numFour == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", numOne, numTwo, numThree, numFour);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
