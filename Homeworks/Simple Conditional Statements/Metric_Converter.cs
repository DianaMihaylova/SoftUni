using System;

namespace _08.Metric_Converter
{
    class Metric_Converter
    {
        static void Main()
        {
            var num = double.Parse(Console.ReadLine());
            var sourceMetric = Console.ReadLine().ToLower();
            var destMetric = Console.ReadLine().ToLower();
            if (sourceMetric == "km")
            {
                num = num / 0.001;
            }
            else if (sourceMetric == "mm")
            {
                num = num / 1000;
            }
            else if (sourceMetric == "cm")
            {
                num = num / 100;
            }
            else if (sourceMetric == "mi")
            {
                num = num / 0.000621371192;
            }
            else if (sourceMetric == "in")
            {
                num = num / 39.3700787;
            }
            else if (sourceMetric == "ft")
            {
                num = num / 3.2808399;
            }
            else if (sourceMetric == "yd")
            {
                num = num / 1.0936133;
            }
            if (destMetric == "ft")
            {
                num = num * 3.2808399;
            }
            else if (destMetric == "mm")
            {
                num = num * 1000;
            }
            else if (destMetric == "cm")
            {
                num = num * 100;
            }
            else if (destMetric == "mi")
            {
                num = num * 0.000621371192;
            }
            else if (destMetric == "in")
            {
                num = num * 39.3700787;
            }
            else if (destMetric == "km")
            {
                num = num * 0.001;
            }
            else if (destMetric == "yd")
            {
                num = num * 1.0936133;
            }
            Console.WriteLine(num + " " + destMetric);
        }
    }
}
