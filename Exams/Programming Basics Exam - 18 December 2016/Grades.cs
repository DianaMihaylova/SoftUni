using System;

namespace Problem_04.Grades1
{
    class Grades
    {
        static void Main()
        {
            var numStudents = int.Parse(Console.ReadLine());

            var sumOne = 0.00;
            var sumTwo = 0.00;
            var sumThree = 0.00;
            var sumFour = 0.00;
            var midSuccess = 0.0;
            for (int i = 1; i <= numStudents; i++)
            {
                var evalExam = double.Parse(Console.ReadLine());
                midSuccess += evalExam;
                if (evalExam >= 2 && evalExam <= 2.99)
                {
                    sumOne++;
                }
                if (evalExam >= 3 && evalExam <= 3.99)
                {
                    sumTwo++;
                }
                if (evalExam >= 4 && evalExam <= 4.99)
                {
                    sumThree++;
                }
                if (evalExam >= 5)
                {
                    sumFour++;
                }
            }
            Console.WriteLine("Top students: {0:f2}%", (sumFour / numStudents) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (sumThree / numStudents) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (sumTwo / numStudents) * 100);
            Console.WriteLine("Fail: {0:f2}%", (sumOne / numStudents) * 100);
            Console.WriteLine("Average: {0:f2}", midSuccess / numStudents);
        }
    }
}
