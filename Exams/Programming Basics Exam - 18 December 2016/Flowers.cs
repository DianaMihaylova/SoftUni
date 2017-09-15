using System;

namespace Problem_03.Flowers1
{
    class Flowers
    {
        static void Main()
        {
            var numHriz = int.Parse(Console.ReadLine());
            var numRose = int.Parse(Console.ReadLine());
            var numLal = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var day = Console.ReadLine();

            var priceHriz = 0.0;
            var priceRose = 0.0;
            var priceLal = 0.0;
            var allNumFlower = numHriz + numRose + numLal;
            if (season == "spring" || season == "summer")
            {
                priceHriz = 2.00;
                priceRose = 4.10;
                priceLal = 2.50;
            }
            else if (season == "autumn" || season == "winter")
            {
                priceHriz = 3.75;
                priceRose = 4.50;
                priceLal = 4.15;
            }
            var allFlower = (numHriz * priceHriz) + (numRose * priceRose) + (numLal * priceLal);
            if (day == "Y")
            {
                allFlower = allFlower + (allFlower * 0.15);
            }
            if (season == "spring" && numLal > 7)
            {
                allFlower = allFlower - (allFlower * 0.05);
            }
            if (season == "winter" && numRose >= 10)
            {
                allFlower = allFlower - (allFlower * 0.10);
            }
            if (allNumFlower > 20)
            {
                allFlower = allFlower - (allFlower * 0.20);
            }
            var allPriceFlower = allFlower + 2;
            Console.WriteLine("{0:f2}", allPriceFlower);
        }
    }
}
