using System;

namespace _13.Point_in_the_Figure
{
    class Point_in_the_Figure
    {
        static void Main()
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var x1 = 0;
            var y1 = 0;
            var x2 = 3 * h;
            var y2 = h;

            var x3 = h;
            var y3 = h;
            var x4 = 2 * h;
            var y4 = 4 * h;

            if ((x > x1 && x < x2 && y > y1 && y < y2) || (x > x3 && x < x4 && y == y3) || (x > x3 && x < x4 && y > y3 && y < y4))
            {
                Console.WriteLine("Inside");
            }
            else if ((((x == x1 || x == x2) && y >= y1 && y <= y2) || ((y == y1 || y == y2) && x >= x1 && x <= x2)) || (((x == x3 || x == x4) && y >= y3 && y <= y4) || ((y == y3 || y == y4) && x >= x3 && x <= x4)))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
