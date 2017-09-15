using System;

namespace Problem_02___Styrofoam
{
    class Styrofoam
    {
        static void Main()
        {
            var budget = decimal.Parse(Console.ReadLine());
            var houseArea = double.Parse(Console.ReadLine());
            var numWindows = int.Parse(Console.ReadLine());
            var styrifiamPerPackage = double.Parse(Console.ReadLine());
            var priceStyrofoam = decimal.Parse(Console.ReadLine());

            var realHouseArea = houseArea - (numWindows * 2.4);
            var procentArea = realHouseArea + (realHouseArea * 0.10);
            var needPackage = Math.Ceiling(procentArea / styrifiamPerPackage);
            var neededSum = (decimal)needPackage * priceStyrofoam;
            if (neededSum < budget)
            {
                Console.WriteLine("Spent: {0:f2}", neededSum);
                Console.WriteLine("Left: {0:f2}", budget - neededSum);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", neededSum - budget);
            }
        }
    }
}
