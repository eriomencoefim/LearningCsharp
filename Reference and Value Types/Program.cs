using System;

namespace Reference_and_Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5};
            int[] array2 = array;
            array[2] = 4000;

            int integer = 3;
            int integer2 = integer;
            integer = 4000;

            Console.WriteLine($"array2[2]: {array2[2]} integer2: {integer2}");
        }
    }
}
