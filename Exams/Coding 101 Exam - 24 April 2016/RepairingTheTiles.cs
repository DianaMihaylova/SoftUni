using System;

namespace _01.RepairingTheTiles
{
    class RepairingTheTiles
    {
        static void Main()
        {
            var hLand = int.Parse(Console.ReadLine());
            var wTiles = double.Parse(Console.ReadLine());
            var hTiles = double.Parse(Console.ReadLine());
            var wBench = int.Parse(Console.ReadLine());
            var hBench = int.Parse(Console.ReadLine());
            var areaLand = hLand * hLand;
            var areaBench = wBench * hBench;
            var areaLandTiles = areaLand - areaBench;
            var areaTiles = wTiles * hTiles;
            var allAreaTiles = (double)areaLandTiles / areaTiles;
            var time = allAreaTiles * 0.2;
            Console.WriteLine(allAreaTiles);
            Console.WriteLine(time);
        }
    }
}
