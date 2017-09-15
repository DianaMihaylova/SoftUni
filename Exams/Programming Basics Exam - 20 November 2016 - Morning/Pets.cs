using System;

namespace _02.Pets
{
    class Pets
    {
        static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var foodKg = int.Parse(Console.ReadLine());
            var dogFoodKg = double.Parse(Console.ReadLine());
            var catFoodKg = double.Parse(Console.ReadLine());
            var turtleFoodGr = double.Parse(Console.ReadLine());

            var dogFoodNeed = days * dogFoodKg;
            var catFoodNeed = days * catFoodKg;
            var turtleFoodNeed = (days * turtleFoodGr) / 1000;
            var allFoodNeed = dogFoodNeed + catFoodNeed + turtleFoodNeed;
            var diffFood = Math.Abs(foodKg - allFoodNeed);
            if (foodKg >= allFoodNeed)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(diffFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(diffFood));
            }
        }
    }
}
