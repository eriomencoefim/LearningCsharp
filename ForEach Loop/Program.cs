using System;

namespace ForEach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] age = new double[4];
            foreach (var result in age)
            {
                Console.WriteLine($"Please input age");
                Console.ReadLine();
                
            }
            
        }
    }
}
