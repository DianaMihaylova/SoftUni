using System;

namespace Problem_04___Bills
{
    class Bills
    {
        static void Main()
        {
            var numMonths = int.Parse(Console.ReadLine());
            var sum = 0.0m;
            var electricity = 0.0m;
            for (int i = 1; i <= numMonths; i++)
            {
                var billPerMonth = decimal.Parse(Console.ReadLine());
                sum = billPerMonth;
                electricity += sum;
            }
            var water = numMonths * 20;
            var internet = numMonths * 15;
            var otherBills = electricity + (numMonths * 20) + (numMonths * 15);
            var otherBillsProcent = (otherBills + (otherBills * 0.20m));
            var average = (electricity + water + internet + otherBillsProcent) / numMonths;
            Console.WriteLine("Electricity: {0:f2} lv", electricity);
            Console.WriteLine("Water: {0:f2} lv", water);
            Console.WriteLine("Internet: {0:f2} lv", internet);
            Console.WriteLine("Other: {0:f2} lv", otherBillsProcent);
            Console.WriteLine("Average: {0:f2} lv", average);
        }
    }
}
