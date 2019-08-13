using System;

namespace Escaping
{
    class Program
    {
        static void Main()
        {
            Console.WindowWidth = 23;
            Console.BufferWidth = 23;
            Console.WindowHeight = 29;
            Console.BufferHeight = 29;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("|=====================|");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|Protein Intake Week:1|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("|=====================|");
            Console.BackgroundColor = ConsoleColor.Green;
            float firstDay = 80.88557f;
            Console.WriteLine($"|{firstDay,21:N}|");
            float secondDay = 94.56465f;
            Console.WriteLine($"|{secondDay,21:N}|");
            float thirdDay = 78.67893f;
            Console.WriteLine($"|{thirdDay,21:N}|");
            float fourthDay = 88.66654f;
            Console.WriteLine($"|{fourthDay,21:N}|");
            float fifthDay = 88.6466f;
            Console.WriteLine($"|{fifthDay,21:N}|");
            float sixthDay = 76.777f;
            Console.WriteLine($"|{sixthDay,21:N}|");
            float seventhDay = 91.85759f;
            Console.WriteLine($"|{seventhDay,21:N}|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("|=====================|");

            float i = firstDay + secondDay + thirdDay + fourthDay + fifthDay + sixthDay + seventhDay;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"|Total:{i,15:C}|");
            Console.BackgroundColor = ConsoleColor.Red; 
            Console.WriteLine("|=====================|");
            Console.ResetColor();
        }
}   }
