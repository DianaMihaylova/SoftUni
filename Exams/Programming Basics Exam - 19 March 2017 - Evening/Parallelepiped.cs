using System;

namespace Problem_05___Parallelepiped
{
    class Parallelepiped
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var height = 4 * n + 4;
            var width = 3 * n + 1;
            var dots = n * 2;
            var dotsTwo = n * 2;
            Console.WriteLine("+{0}+{1}", new string('~', n -2), new string('.', n * 2 + 1));
            for (int i = 0; i < n * 2 + 1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', i), new string('~', n -2), new string('.', dots));
                dots--;
            }
            for (int i = 0; i < n * 2 + 1; i++)
            {
               Console.WriteLine("{0}\\{1}|{2}|", new string('.', i), new string('.', dotsTwo), new string('~', n - 2));
                dotsTwo--;
            }
            Console.WriteLine("{0}+{1}+", new string('.', n * 2 + 1), new string('~', n - 2));
        }
    }
}
