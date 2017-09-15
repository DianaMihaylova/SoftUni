using System;

namespace Problem_03___Truck_Driver
{
    class TruckDriver
    {
        static void Main()
        {
            var season = Console.ReadLine().ToLower();
            var kmPerMonth = double.Parse(Console.ReadLine());

            var price = 0.0;
            if (kmPerMonth <= 5000)
            {
                switch (season)
                {
                    case "spring":
                        price = 0.75;
                        break;
                    case "autumn":
                        price = 0.75;
                        break;
                    case "summer":
                        price = 0.90;
                        break;
                    case "winter":
                        price = 1.05;
                        break;
                }
            }
            if (kmPerMonth > 5000 && kmPerMonth <= 10000)
            {
                switch (season)
                {
                    case "spring":
                        price = 0.95;
                        break;
                    case "autumn":
                        price = 0.95;
                        break;
                    case "summer":
                        price = 1.10;
                        break;
                    case "winter":
                        price = 1.25;
                        break;
                }
            }
            if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                price = 1.45;
            }
            var salary = kmPerMonth * price * 4;
            var taxSalary = salary - (salary * 0.10);
            Console.WriteLine("{0:f2}", taxSalary);
        }
    }
}
