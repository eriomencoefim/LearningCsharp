using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace ForLoops
{
    class Program
    {
        static void Main()
        {
            //int number = 1;
            //while (number < 10)
            //{
            //    Console.WriteLine();
            //    number++;
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i);

            //int[] numbers = {1, 2, 3, 6, 8, 7};
            //for (int i = 0; i < numbers.Length; i++ )
            //{
            //    Console.WriteLine($"Current Index {i}, current element is {numbers[i]}");

            //}
            int choice = 0;
            bool newChoice = false;
            string[] fruits = new string[10];
            fruits[0] = "kiwi";
            fruits[1] = "banana";

            while (!newChoice)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("1. Add new item" +
                                  "\n2. Edit item" +
                                  "\n3. Remove item" +
                                  "\n4. View All Items" +
                                  "\n5. Exit" +
                                  "\nYour choice:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                choice = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                switch (choice)
                {
                    case 1:
                        for  (int i = 0; i < fruits.Length; i++)
                        {
                            if (fruits[i] == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Please add a new fruit: ");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                fruits[i] = Console.ReadLine();
                                Console.ResetColor();
                                break;
                            }
                        }
                        break;
                    case 2:
                        int itemchosen = 0;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Which fruit do you want to change (1 to 10):");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        itemchosen = Convert.ToInt32(Console.ReadLine());
                        Console.ResetColor();
                        fruits[itemchosen - 1] = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Number {itemchosen} was changed");
                        Console.ResetColor();
                        break; 
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Which fruit do you want to remove?(1 to 10)");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        int itemtodelete = Convert.ToInt32(Console.ReadLine());
                        fruits[itemtodelete - 1] = null;
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Current fruits:");
                        Console.ResetColor();
                        for (int i = 0; i < fruits.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(fruits[i]);
                            Console.ResetColor();
                        }

                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("This option doesn't exit ");
                        break;
                }
            }
        }
    }
}
