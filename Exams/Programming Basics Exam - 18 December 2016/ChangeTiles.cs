using System;

namespace Problem_02.Change_Tiles1
{
    class ChangeTiles
    {
        static void Main()
        {
            var spendMoney = decimal.Parse(Console.ReadLine());
            var floorW = decimal.Parse(Console.ReadLine());
            var floorH = decimal.Parse(Console.ReadLine());
            var a = decimal.Parse(Console.ReadLine());
            var h = decimal.Parse(Console.ReadLine());
            var pricePerTile = decimal.Parse(Console.ReadLine());
            var sumWorker = decimal.Parse(Console.ReadLine());

            var allFloor = floorW * floorH;
            var oneTile = (a * h) / 2;
            var needTiles = Math.Ceiling(allFloor / oneTile) + 5;
            var needSum = (needTiles * pricePerTile) + sumWorker;
            if (spendMoney >= needSum)
            {
                Console.WriteLine("{0:f2} lv left.", spendMoney - needSum);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", needSum - spendMoney);
            }
        }
    }
}
