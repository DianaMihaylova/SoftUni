using System;

namespace _11.Enter_Even_Number
{
    class EnterEvenNumber
    {
        static void Main()
        {
            int n = 0;

            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
