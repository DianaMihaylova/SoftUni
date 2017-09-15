using System;

namespace _03.Operations
{
    class Operations
    {
        static void Main()
        {
            var nOne = int.Parse(Console.ReadLine());
            var nTwo = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            var plusResult = nOne + nTwo;
            var minResult = nOne - nTwo;
            var multResult = nOne * nTwo;

            if (nTwo == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", nOne);
            }
            else
            {
                switch (symbol)
                {
                    case "+":
                        Console.WriteLine("{0} {1} {2} = {3} - {4}", nOne, symbol, nTwo, plusResult, plusResult % 2 == 0 ? "even" : "odd");
                        break;
                    case "-":
                        Console.WriteLine("{0} {1} {2} = {3} - {4}", nOne, symbol, nTwo, minResult, minResult % 2 == 0 ? "even" : "odd");
                        break;
                    case "*":
                        Console.WriteLine("{0} {1} {2} = {3} - {4}", nOne, symbol, nTwo, multResult, multResult % 2 == 0 ? "even" : "odd");
                        break;
                    case "/":
                        Console.WriteLine("{0} {1} {2} = {3:f2}", nOne, symbol, nTwo, (double)nOne / nTwo);
                        break;
                    case "%":
                        Console.WriteLine("{0} {1} {2} = {3}", nOne, symbol, nTwo, nOne % nTwo);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
