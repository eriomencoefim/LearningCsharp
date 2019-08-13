using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Basic_Class
{
    public static class Tools
        {
            public static void ColorTools(string text , ConsoleColor color) 
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Hello");
                Console.ResetColor();
            }
        }
}
