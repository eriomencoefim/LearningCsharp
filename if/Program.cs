using System;
using System.ComponentModel.Design;

namespace ifdaca
{
    class Program
{
        static void Main(string[] args)
        {
            //int firstNumber = 4;
            //int secondNumer = 5;


            //if (firstNumber < secondNumer)
            //{
            //    Console.WriteLine("4 mai mic decat 5");
            //}

      
            Console.WriteLine("Username:");
            string tempUsername = Console.ReadLine(); 

            Console.WriteLine("Password:");
            string tempPassword = Console.ReadLine();

            string username = "default_user";
            if (tempUsername.Length <= 6)
            {
                username = tempUsername;
            }
           


        }
}
}
