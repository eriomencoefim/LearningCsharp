using System;

namespace Bubble_sort
{
    class Program
    {
        static void Main()
        {
            int[] array = { 9, 7, 4, 3, 6 };
            Console.WriteLine(string.Join(',', array));
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    int first = array[j];
                    int next = array[j + 1];

                    if (first > next)
                    {
                        array[j + 1] = first;
                        array[j] = next;
                    }
                    Console.WriteLine(string.Join(',', array));
                }
                Console.WriteLine(string.Join(',', array));
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(string.Join(',',array));
            Console.ResetColor();


        }
    }
}
