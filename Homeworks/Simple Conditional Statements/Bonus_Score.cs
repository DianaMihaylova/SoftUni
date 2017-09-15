using System;

namespace _06.Bonus_Score
{
    class Bonus_Score
    {
        static void Main()
        {
            Console.Write("Enter score: ");
            var a = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;
            if (a <= 100)
            {
                bonusScore = 5;
            }
            else if (a < 1000)
            {
                bonusScore = a * 0.2;
            }
            else if (a > 1000)
            {
                bonusScore = a * 0.1;
            }
            if (a % 2 == 0)
            {
                bonusScore += 1;
            }
            else if (a % 10 == 5)
            {
                bonusScore += 2;
            }
            Console.WriteLine("Bonus score: {0}", bonusScore);
            Console.WriteLine("Total score: {0}", a + bonusScore);
        }
    }
}
