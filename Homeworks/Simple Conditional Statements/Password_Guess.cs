using System;

namespace _09.Password_Guess
{
    class Password_Guess
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var pass = "s3cr3t!P@ssw0rd";
            if (text == pass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
