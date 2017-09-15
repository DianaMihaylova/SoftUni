using System;

namespace Problem_01___Grape_and_Rakia
{
    class GrapeRakia
    {
        static void Main()
        {
            var vineyard = double.Parse(Console.ReadLine());
            var kgPerMetur = double.Parse(Console.ReadLine());
            var morevine = double.Parse(Console.ReadLine());

            var allVineyard = vineyard * kgPerMetur;
            var stayVine = allVineyard - morevine;
            var rakia = stayVine * 0.45;
            var litra = rakia / 7.5;
            var profitRakia = litra * 9.80;
            var sales = stayVine * 0.55;
            var profitGrape = sales * 1.50;
            Console.WriteLine("{0:f2}", profitRakia);
            Console.WriteLine("{0:f2}", profitGrape);
        }
    }
}
