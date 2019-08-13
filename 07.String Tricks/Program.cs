using System;

namespace _07.String_Tricks
{
    class Program
    {
        static void Main()
        {
            string fruitJuice = "Strawberry juice";
            bool containsStraw = fruitJuice.ToLower().Contains("");
            Console.WriteLine(containsStraw);
        }
    }
}
