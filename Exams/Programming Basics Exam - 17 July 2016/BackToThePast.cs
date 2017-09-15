using System;

namespace _04.Back_To_The_Past
{
    class BackToThePast
    {
        static void Main()
        {
            var money = decimal.Parse(Console.ReadLine());
            var yearLife = int.Parse(Console.ReadLine());
            var spendMoney = 0m;
            var yearsOld = 17;

            for (int i = 1800; i <= yearLife; i++)
            {
                if (i % 2 != 0)
                {
                    yearsOld++;
                    spendMoney += (12000 + (50 * yearsOld));
                }
                else
                {
                    yearsOld++;
                    spendMoney += 12000;
                }
            }
            if (money >= spendMoney)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money - spendMoney);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", spendMoney - money);
            }
        }
    }
}
