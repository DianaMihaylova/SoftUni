using System;

namespace _03.Match_Tickets
{
    class Match_Tickets
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var numPersons = int.Parse(Console.ReadLine());
            var budgetRemain = 0.0;
            var ticketPrice = 0.0;


            if (numPersons <= 4)
            {
                budgetRemain = budget - (budget * 0.75);
            }
            else if (numPersons >= 5 && numPersons <= 9)
            {
                budgetRemain = budget - (budget * 0.60);
            }
            else if (numPersons >= 10 && numPersons <= 24)
            {
                budgetRemain = budget - (budget * 0.50);
            }
            else if (numPersons >= 25 && numPersons <= 49)
            {
                budgetRemain = budget - (budget * 0.40);
            }
            else if (numPersons >= 50)
            {
                budgetRemain = budget - (budget * 0.25);
            }
            switch (category)
            {
                case "VIP":
                    ticketPrice = numPersons * 499.99;
                    break;
                case "Normal":
                    ticketPrice = numPersons * 249.99;
                    break;
                default:
                    break;
            }
            if (budgetRemain >= ticketPrice)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", budgetRemain - ticketPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", ticketPrice - budgetRemain);
            }
        }
    }
}
