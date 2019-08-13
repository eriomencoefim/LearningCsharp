using System;
using System.Net;
using System.Runtime.InteropServices.ComTypes;

namespace _METD_Three_numbers
{
    class Program
    {
        static void Main()
        {
            Console.Write(Multi(4,5));
            ConnectToDB("Efim","123345");
            Console.WriteLine(ThreeNumbers(1,2));
        }

        static int ThreeNumbers(int firstNumber, int secondNumber, int ThirdNumber = 0)
        {
            return firstNumber + secondNumber + ThirdNumber;
        }

        static int Multi(int firstNumber, int secondNumber, int ThirdNumber = 1)
        {
            return firstNumber * secondNumber * ThirdNumber;
        }

        static void ConnectToDB(string username, string password, string ip = "127.0.0.0.1")
        {
            Console.WriteLine($"\nHello {username},connecting to {ip} please wait...");
        }
    }
}
