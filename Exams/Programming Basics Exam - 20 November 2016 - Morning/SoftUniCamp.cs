using System;

namespace _04.SoftUni_Camp
{
    class SoftUniCamp
    {
        static void Main()
        {
            var studentGroup = int.Parse(Console.ReadLine());

            var numAll = 0.00;
            var studentCar = 0;
            var studentBus = 0;
            var studentSmallBus = 0;
            var studentHugeBus = 0;
            var studentTrain = 0;
            for (int i = 1; i <= studentGroup; i++)
            {
                var numStudents = int.Parse(Console.ReadLine());
                numAll += numStudents;
                if (numStudents <= 5)
                {
                    studentCar += numStudents;
                }
                else if (numStudents >= 6 && numStudents <= 12)
                {
                    studentBus += numStudents;
                }
                else if (numStudents >= 13 && numStudents <= 25)
                {
                    studentSmallBus += numStudents;
                }
                else if (numStudents >= 26 && numStudents <= 40)
                {
                    studentHugeBus += numStudents;
                }
                else if (numStudents >= 41)
                {
                    studentTrain += numStudents;
                }
            }
            Console.WriteLine("{0:f2}%", (studentCar / numAll) * 100);
            Console.WriteLine("{0:f2}%", (studentBus / numAll) * 100);
            Console.WriteLine("{0:f2}%", (studentSmallBus / numAll) * 100);
            Console.WriteLine("{0:f2}%", (studentHugeBus / numAll) * 100);
            Console.WriteLine("{0:f2}%", (studentTrain / numAll) * 100);
        }
    }
}
