using System;

namespace _13.Area_of_Figures
{
    class Area_of_Figures
    {
        static void Main()
        {
            var figure = Console.ReadLine();
            var a = double.Parse(Console.ReadLine());
            var f1 = "square";
            var f2 = "rectangle";
            var f3 = "circle";
            var f4 = "triangle";
            var area = Math.PI * a * a;
            if (figure == f1)
            {
                Console.WriteLine(Math.Round(a*a, 3));
            }
            else if (figure == f2)
            {
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a*b, 3));
            }
            else if (figure == f3)
            {
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == f4)
            {
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * b) / 2, 3));
            }
        }
    }
}
