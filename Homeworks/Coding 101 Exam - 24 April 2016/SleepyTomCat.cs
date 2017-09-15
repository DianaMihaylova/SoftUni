using System;

namespace _02.SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main()
        {
            var holidays = int.Parse(Console.ReadLine());
            var holidayPlay = holidays * 127;
            var weekdayPlay = (365 - holidays) * 63;
            var allGame = holidayPlay + weekdayPlay;
            var diff = Math.Abs(30000 - allGame);

            if (allGame < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", diff / 60, diff % 60);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", diff / 60, diff % 60);
            }
        }
    }
}
