using System;

namespace Problem_01.Distance1
{
    class Distance
    {
        static void Main()
        {
            var firstSpeed = int.Parse(Console.ReadLine());
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var tirthTime = int.Parse(Console.ReadLine());

            var firstDistance = firstSpeed * (firstTime / 60d);
            var secondSpeed = firstSpeed + (firstSpeed * 0.10d);
            var secondDistance = secondSpeed * (secondTime / 60d);
            var tirthSpeed = secondSpeed - (secondSpeed * 0.05d);
            var tirthDistance = tirthSpeed * (tirthTime / 60d);
            var allDistance = firstDistance + secondDistance + tirthDistance;
            Console.WriteLine("{0:f2}", allDistance);
        }
    }
}
