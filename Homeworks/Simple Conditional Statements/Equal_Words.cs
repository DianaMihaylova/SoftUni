using System;

namespace _11.Equal_Words
{
    class Equal_Words
    {
        static void Main()
        {
            var word1 = Console.ReadLine().ToLower();
            var word2 = Console.ReadLine().ToLower();
            if (word1 == word2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
