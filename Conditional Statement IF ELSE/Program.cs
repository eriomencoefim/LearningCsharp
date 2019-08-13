using System;

namespace Conditional_Statement_IF_ELSE
{
    class Program
    {
        static void Main()
        {
            int firstNumber = 5;
            int secondNumber = 6;

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


