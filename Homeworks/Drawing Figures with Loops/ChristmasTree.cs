using System;

namespace Christmas_Tree
{
    class ChristmasTree
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{2}|{2}{1}", new string(' ', n - i), new string('*', i), new string(' ', 1), new string(' ', i));
            }
        }
    }
}
