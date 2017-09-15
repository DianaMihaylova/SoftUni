using System;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            var year = Console.ReadLine().ToLower();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());

            var weekSofia = (48 - h) * 3 / 4.00;
            var weekHome = h;
            var weekHoliday = p * 2 / 3.00;
            var allGames = weekSofia + weekHome + weekHoliday;
            var allGamesLeap = allGames + (allGames * 0.15);

            if (year == "leap")
            {
                Console.WriteLine(Math.Floor(allGamesLeap));
            }
            else
            {
                Console.WriteLine(Math.Floor(allGames));
            }
        }
    }
}
