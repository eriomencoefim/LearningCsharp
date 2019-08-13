using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            PrintingNames("Tod", "Vachev");
            PrintingNames("Bob", "Marley");
            ColorfulWriteLine("My name is Tod", ConsoleColor.Yellow);
        }

        static void ColorfulWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static void PrintingNames(string firstName, string secondName)
        {
            Console.WriteLine($"My name is {firstName} {secondName}");
             
        }
    }
}
