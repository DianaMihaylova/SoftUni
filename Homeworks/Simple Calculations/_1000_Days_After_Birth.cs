using System;
using System.Globalization;

namespace _1000_Days_After_Birth
{
    class _1000_Days_After_Birth
    {
        static void Main()
        {
            string birthDate = Console.ReadLine();
            var format = "dd-MM-yyyy";
            var birthDateAfter = DateTime.ParseExact(birthDate, format, CultureInfo.InvariantCulture);
            birthDateAfter = birthDateAfter.AddDays(999);
            Console.WriteLine(birthDateAfter.ToString(format));
        }
    }
}
