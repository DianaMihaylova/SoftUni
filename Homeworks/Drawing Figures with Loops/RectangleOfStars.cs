using System;

namespace Rectangle_of_10_x_10_Stars
{
    class RectangleOfStars
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new string('*', 10));
            }
        }
    }
}
