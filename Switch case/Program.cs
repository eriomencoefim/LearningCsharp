using System;
using System.ComponentModel;

namespace Switch_case
{
    class Program
    {
        static void Main()
        {
            

            Console.WriteLine($"\n1. Add new item" +
                              "\n2. Edit Item" +
                              "\n3. Remove item" +
                              "\n4. Exit");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine($"{number} You added a new item");
                    break;
                case 2:
                    Console.WriteLine($"{number} You edited the item");
                    break;
                case 3:
                    Console.WriteLine($"{number} You've removed the item");
                    break;
                case 4:
                    Console.WriteLine($"{number} You've exit");
                    break;
                default:
                    Console.WriteLine("This option doesn't exit ");
                    break;
            }
        }
    }
}
