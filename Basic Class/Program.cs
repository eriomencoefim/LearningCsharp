using System;
using System.Runtime.Serialization;
using MagicDestroyers.Enumerations;

namespace Basic_Class
{
    class Program
    {
        static void Main()
        {
            Warrior goodGuy = new Warrior(10,100,Factions.GoodGuy);


           

            Console.WriteLine($"Good guy HP {goodGuy.HealthPoints}");
           
        }
    }
}
