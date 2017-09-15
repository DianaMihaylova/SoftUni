using System;

namespace Currency_Converter
{
    class Currency_Converter
    {
        static void Main()
        {
            decimal sum = decimal.Parse(Console.ReadLine());
            string currencyEntr = Console.ReadLine();
            string currencyExit = Console.ReadLine();
            decimal convertionOne = new decimal();
            decimal convertionTwo = new decimal();
            decimal BGN = 1;
            decimal USD = 1.79549m;
            decimal EUR = 1.95583m;
            decimal GBP = 2.53405m;
            switch (currencyEntr)
            {
                case "BGN":
                    convertionOne = sum * BGN;
                    break;
                case "USD":
                    convertionOne = sum * USD;
                    break;
                case "EUR":
                    convertionOne = sum * EUR;
                    break;
                case "GBP":
                    convertionOne = sum * GBP;
                    break;
            }
            switch (currencyExit)
            {
                case "BGN":
                    convertionTwo = convertionOne / BGN;
                    break;
                case "USD":
                    convertionTwo = convertionOne / USD;
                    break;
                case "EUR":
                    convertionTwo = convertionOne / EUR;
                    break;
                case "GBP":
                    convertionTwo = convertionOne / GBP;
                    break;
            }
            Console.WriteLine(Math.Round(convertionTwo, 2));
        }
    }
}
