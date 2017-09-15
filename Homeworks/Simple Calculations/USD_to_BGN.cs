using System;

namespace USD_to_BGN
{
    class USD_to_BGN
    {
        static void Main()
        {
            var usd = decimal.Parse(Console.ReadLine());
            var bgn = usd * 1.79549m;
            Console.WriteLine(Math.Round(bgn, 2));
        }
    }
}
