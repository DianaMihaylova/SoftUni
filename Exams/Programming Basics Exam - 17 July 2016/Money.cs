using System;

namespace _01.Money
{
    class Money
    {
        static void Main()
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var china = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());

            var bitcoinToLev = bitcoin * 1168;
            var chinaToLev = (china * 0.15) * 1.76;
            var allEuro = (bitcoinToLev + chinaToLev) / 1.95;
            var allSumEuro = allEuro - (allEuro * commission / 100);
            Console.WriteLine(allSumEuro);
        }
    }
}
