using System;
using System.ComponentModel.Design;

namespace ifelse
{
    class Program
    {
         static void Main()

        {
            //1.CHALLENGE
            int i;
            Console.WriteLine("Enter a number:");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber) 
            {
                Console.WriteLine($"The number {firstNumber} is bigger than {secondNumber}");
            }
            else
            {
                Console.WriteLine($"The number {firstNumber} is lower than {secondNumber}");
            }
        }

    }
}
