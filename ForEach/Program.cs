using System;

namespace ForEach
{
    class Program
    {
        static void Main()
        {
            int[] array = {1, 5, 4, 2};

            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            foreach (var ghjhgfjfgh in array)
            {
                Console.WriteLine(ghjhgfjfgh);
            }
        }
    }
}
