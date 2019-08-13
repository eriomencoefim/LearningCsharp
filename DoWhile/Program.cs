using System;

namespace DoWhile
{
    class Program
    {
        static void Main()
        {

            int firstNumber = 12;
            int endNumber = 10;
            //while (firstNumber <= endNumber)
            //{
            //    Console.WriteLine(firstNumber);
            //    firstNumber++;
            //}

            do
            {
                Console.WriteLine(firstNumber);
                firstNumber++;
            } while (firstNumber<=endNumber);
        }
    }
}
