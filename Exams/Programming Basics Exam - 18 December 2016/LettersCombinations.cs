using System;

namespace Problem_06.Letters_Combinations1
{
    class LettersCombinations
    {
        static void Main()
        {
            var letterBegin = char.Parse(Console.ReadLine());
            var letterEnd = char.Parse(Console.ReadLine());
            var letterDiff = char.Parse(Console.ReadLine());

            var combination = 0;

            for (char i = letterBegin; i <= letterEnd; i++)
            {
                for (char k = letterBegin; k <= letterEnd; k++)
                {
                    for (char j = letterBegin; j <= letterEnd; j++)
                    {
                        if (i != letterDiff && k != letterDiff && j != letterDiff)
                        {
                            Console.Write("{0}{1}{2} ", i, k, j);
                            combination++;
                        }
                    }
                }
            }
            Console.WriteLine("{0}", combination);
        }
    }
}
