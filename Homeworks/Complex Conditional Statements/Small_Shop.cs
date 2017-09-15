using System;

namespace _02.Small_Shop
{
    class Small_Shop
    {
        static void Main()
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            if (town == "sofia")
            {
                if (product == "coffee") Console.WriteLine(0.50 * quantity);
                if (product == "water") Console.WriteLine(0.80 * quantity);
                if (product == "beer") Console.WriteLine(1.20 * quantity);
                if (product == "sweets") Console.WriteLine(1.45 * quantity);
                if (product == "peanuts") Console.WriteLine(1.60 * quantity);
            }
            if (town == "plovdiv")
            {
                if (product == "coffee") Console.WriteLine(quantity * 0.40);
                if (product == "water") Console.WriteLine(quantity * 0.70);
                if (product == "beer") Console.WriteLine(quantity * 1.15);
                if (product == "sweets") Console.WriteLine(quantity * 1.30);
                if (product == "peanuts") Console.WriteLine(quantity * 1.50);
            }
            if (town == "varna")
            {
                if (product == "coffee") Console.WriteLine(quantity * 0.45);
                if (product == "water") Console.WriteLine(quantity * 0.70);
                if (product == "beer") Console.WriteLine(quantity * 1.10);
                if (product == "sweets") Console.WriteLine(quantity * 1.35);
                if (product == "peanuts") Console.WriteLine(quantity * 1.55);
            }
        }
    }
}
