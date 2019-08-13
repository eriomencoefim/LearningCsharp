using System;
using System.Runtime.InteropServices;

namespace Array_Reversing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = {"orange","melon", "kiwi", "cherry", "banana"};
            Reverse(fruits);

            Console.WriteLine(string.Join(',', fruits ));

        }

        private static void Reverse(string[] fruits)
        {
            for (int i = 0; i < fruits.Length/2; i++)
            {
                string first = fruits[i];
                string last = fruits[fruits.Length - 1 - i];
                //doar ca nu last dar next

                fruits[fruits.Length - 1 - i] = first;
                fruits[i] = last;

            }
        }
    }
}
