using System;

namespace _03.Vacation
{
    class Vacation
    {
        static void Main()
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var adultPrice = 0.0;
            var studentPrice = 0.0;
            switch (transport)
            {
                case "train":
                    adultPrice = 24.99;
                    studentPrice = 14.99;
                    if (adults + students >= 50)
                    {
                        adultPrice = 24.99 - (24.99 * 0.50);
                        studentPrice = 14.99 - (14.99 * 0.50);
                    }
                    break;
                case "bus":
                    adultPrice = 32.50;
                    studentPrice = 28.50;
                    break;
                case "boat":
                    adultPrice = 42.99;
                    studentPrice = 39.99;
                    break;
                case "airplane":
                    adultPrice = 70.00;
                    studentPrice = 50.00;
                    break;
            }
            var alltransport = ((adults * adultPrice) + (students * studentPrice)) * 2;
            var allnights = nights * 82.99;
            var comission = (alltransport + allnights) * 0.10;
            var allPrice = alltransport + allnights + comission;
            Console.WriteLine("{0:f2}", allPrice);
        }
    }
}
