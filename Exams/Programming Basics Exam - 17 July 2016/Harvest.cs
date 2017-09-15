using System;

namespace _02.Harvest
{
    class Harvest
    {
        static void Main()
        {
            var vineyard = int.Parse(Console.ReadLine());
            var grapesPerSquare = double.Parse(Console.ReadLine());
            var vineLiter = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var grapesAll = vineyard * grapesPerSquare;
            var vineAvailable = ((grapesAll * 40) / 100) / 2.5;
            if (vineAvailable >= vineLiter)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(vineAvailable));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(vineAvailable - vineLiter), Math.Ceiling((vineAvailable - vineLiter) / workers));    
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(vineLiter - vineAvailable));
            }
        }
    }
}
