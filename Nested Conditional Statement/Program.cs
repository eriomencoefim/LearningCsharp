using System;
using System.Runtime.InteropServices;

namespace Nested_Conditional_Statement
{
    class Program
    {
        static void Main()
        {
            //string username = string.Empty;
            //string password = string.Empty;
            //Console.WriteLine("Input your username: ");
            //username = Console.ReadLine();
            //if (username == "admin")
            //{
            //    Console.WriteLine("Welcome admin,input your password :");
            //    password = Console.ReadLine();
            //    if (password == "password")
            //    {
            //        Console.WriteLine("Welcome admin, Full acces granted to you!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry your password is incorrect");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sorry your username is incorrect");

            int a = 75;
            int b = 64;
            int c = 100;
     
            if (a > b && a > c)// max e A
            {
                Console.WriteLine(b > c ? $"{a},{b},{c}" : $"{a},{c},{b}");
            }
            else if (b > a && b > c) // max e b
            {
                Console.WriteLine(c > a ? $"{b},{c},{a}" : $"{b},{a},{c}");
            }
            else// max e c
            {
                Console.WriteLine(b > a ? $"{c},{b},{a}" : $"{c},{a},{b}");
            }

          
           
        }
        
    }
}
