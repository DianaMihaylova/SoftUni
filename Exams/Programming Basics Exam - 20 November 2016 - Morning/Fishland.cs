using System;

namespace _01.Fishland
{
    class Fishland
    {
        static void Main()
        {
            var priceFishS = decimal.Parse(Console.ReadLine());
            var priceFishC = decimal.Parse(Console.ReadLine());
            var kgPal = decimal.Parse(Console.ReadLine());
            var kgSaf = decimal.Parse(Console.ReadLine());
            var kgMid = int.Parse(Console.ReadLine());

            var priceFishPal = (priceFishS + (priceFishS * 0.60m)) * kgPal;
            var priceFishSaf = (priceFishC + (priceFishC * 0.8m)) * kgSaf;
            var priceMid = kgMid * 7.50m;
            var priceAll = priceFishPal + priceFishSaf + priceMid;
            Console.WriteLine("{0:f2}", priceAll);
        }
    }
}
