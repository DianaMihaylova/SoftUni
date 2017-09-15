using System;

namespace _08.Trade_Comissions
{
    class Trade_Comissions
    {
        static void Main()
        {
            string city = Console.ReadLine().ToLower();
            double s = double.Parse(Console.ReadLine());
            var price = -1.0;

            if (city == "sofia")
            {
                if (s >= 0 && s <= 500)
                {
                    price = s * 0.05;
                }
                else if (s > 500 && s <= 1000)
                {
                    price = s * 0.07;
                }
                else if (s > 1000 && s <= 10000)
                {
                    price = s * 0.08;
                }
                else if (s > 10000)
                {
                    price = s * 0.12;
                } 
            }
            else if (city == "varna")
            {
                if (s >= 0 && s <= 500)
                {
                    price = s * 0.045;
                }
                else if (s > 500 && s <= 1000)
                {
                    price = s * 0.075;
                }
                else if (s > 1000 && s <= 10000)
                {
                    price = s * 0.1;
                }
                else if (s > 10000)
                {
                    price = s * 0.13;
                }
            }
            else if (city == "plovdiv")
            {
                if (s >= 0 && s <= 500)
                {
                    price = s * 0.055;
                }
                else if (s > 500 && s <= 1000)
                {
                    price = s * 0.08;
                }
                else if (s > 1000 && s <= 10000)
                {
                    price = s * 0.12;
                }
                else if (s > 10000)
                {
                    price = s * 0.145;
                }
            }
            if (price >= 0)
            {
                Console.WriteLine("{0:f2}", price);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
