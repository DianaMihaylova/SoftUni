using System;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main()
        {
            string film = Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var areaCinema = r * c;
            var priceTicket = 0.0;

            if (film == "premiere")
            {
                priceTicket = 12.00;
            }
            else if (film == "normal")
            {
                priceTicket = 7.50;
            }
            else if (film == "discount")
            {
                priceTicket = 5.00;
            }
            Console.WriteLine("{0:f2}", priceTicket * areaCinema);
        }
    }
}
