using System;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            //int counter=0;
            //while (counter < 10)
            //{
            //    Console.WriteLine("I'm learning about loops");
            //    counter++;
            //}
           
            int number = 0;
            int max = 30;
            int min = 20;
            while (!(number >= min && number <= max))
            {
                Console.WriteLine("Please input a number in the rage 20 to 30:");
                number = Int32.Parse(Console.ReadLine());
                
            }
            Console.WriteLine($"{number} - is a number in the range");
        }
    }
}
