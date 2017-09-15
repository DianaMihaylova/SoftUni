using System;

namespace _06.Battles
{
    class Battles
    {
        static void Main()
        {
            var playerOnePokemon = int.Parse(Console.ReadLine());
            var playerTwoPokemon = int.Parse(Console.ReadLine());
            var maxBattles = int.Parse(Console.ReadLine());

            var count = 0;

            for (int i = 1; i <= playerOnePokemon; i++)
            {

                for (int k = 1; k <= playerTwoPokemon; k++)
                {

                    if (count == maxBattles)
                    {
                        break;
                    }
                    count++;
                    Console.Write("({0} <-> {1}) ", i, k);
                }
            }
        }
    }
}
