using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace Outputting_arrays
{
    class Program
    {
        static void Main()
        {
            Random rng = new Random();
            int[] temperatures = new int[30];
            List<int> blah = new List<int>();
            int[] lowTemperatures = new int[temperatures.Length];
            int[] mediumTemperatures = new int[temperatures.Length];
            int[] highTemperatures = new int[temperatures.Length];
            int[] outOfRange = new int[temperatures.Length];
          
            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = rng.Next(1, 40);
            }
            
            foreach (var currentTemperature in temperatures)
            {
                if (currentTemperature >= 1 && currentTemperature <= 10)
                {
                    Add(lowTemperatures, currentTemperature);
                }
                else if (currentTemperature >= 11 && currentTemperature <= 20)
                {
                    Add(mediumTemperatures, currentTemperature);
                }
                else if (currentTemperature >= 21 && currentTemperature <= 30)
                {
                    Add(highTemperatures, currentTemperature);
                }
                else
                {
                    Add(outOfRange, currentTemperature);
                }
            }

            PrintArray("Low Temperatures: ", lowTemperatures, ConsoleColor.Red);
            PrintArray("Medium Temperatures: ", mediumTemperatures, ConsoleColor.Green);
            PrintArray("High Temperatures: ", highTemperatures, ConsoleColor.Blue);
            PrintArray("OutOfRange Temperatures: ", outOfRange, ConsoleColor.Yellow);


            int[] ages = {1, 23, 4, 5};

            Console.WriteLine(string.Join(' ', ages));

        }

        static void PrintArray(string nameOfArray, int[] array, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(nameOfArray);
            string textToPrint="";
            for (var i = 0; i < array.Length; i++)
            {
                int currentValue = array[i];
                if (currentValue != 0)
                {
                    textToPrint += $"{currentValue}, ";
                }
            }

            textToPrint = textToPrint.Substring(0, textToPrint.Length - 2);
            Console.WriteLine(textToPrint);

            Console.ResetColor();
            Console.WriteLine("\n");
        }

        private static void Add(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = number;
                    break;
                }
            }
        }
    }

    public static class ArrayExtensions
    {
        public static void PrintArray(this int[] array, string name)
        {
            Console.WriteLine(name); 
            foreach (var currentValue in array)
            {
                if (currentValue != 0)
                {
                    Console.Write($"{currentValue}, ");
                }
            }
        }
    }
}
