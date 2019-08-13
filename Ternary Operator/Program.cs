using System;

namespace Ternary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {

            string incomingTemporaryUsername = "prett";
            string username = incomingTemporaryUsername.Length < 6 ? incomingTemporaryUsername : "default_user";
            ConsoleColor color = incomingTemporaryUsername.Length > 6 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.ForegroundColor = color;
            Console.WriteLine(username);

        }
    }
}
