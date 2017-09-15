using System;

namespace _04.SmartLilly
{
    class SmartLilly
    {
        static void Main()
        {
            var ageLilly = int.Parse(Console.ReadLine());
            var priceLaundry = double.Parse(Console.ReadLine());
            var pricePerToy = int.Parse(Console.ReadLine());
            var bonus = 10;
            var sumMoney = 0;
            var sumToys = 0;

            for (int i = 1; i <= ageLilly; i++)
            {
                if (i % 2 == 0)
                {
                    sumMoney += bonus;
                    sumMoney -= 1;
                    bonus += 10;
                }
                else
                {
                    sumToys++;
                }
            }
            var saveMoney = sumMoney;
            var sellToys = sumToys * pricePerToy;
            var allMoney = saveMoney + sellToys;
            if (allMoney >= priceLaundry)
            {
                Console.WriteLine("Yes! {0:f2}", allMoney - priceLaundry);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", priceLaundry - allMoney);
            }
        }
    }
}
