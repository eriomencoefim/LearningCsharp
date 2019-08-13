using System;

namespace MiniWhileGame
{
    class Program
    {
        static void Main()
        {
            var firstPlayer = "John";
            var secondPlayer = "Tom";
            var hp = new Random();
            var firstPlayerDamage = 0;
            var firstPlayerhealth = 100;
            var secondPlayerDamage = 0;
            var secondPlayerhealth = 100;


            while (firstPlayerhealth > 0 && secondPlayerhealth > 0)
            {
                firstPlayerDamage = hp.Next(1, 10);
                secondPlayerDamage = hp.Next(1, 10);

                if (secondPlayerhealth > 0)
                {
                    firstPlayerhealth -= secondPlayerDamage;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    if (firstPlayerhealth <= 0)
                        Console.WriteLine(
                            $"{secondPlayer} inflicted {secondPlayerDamage} damage upon {firstPlayer}.{firstPlayer} is dead");
                    else
                        Console.WriteLine(
                            $"{secondPlayer} inflicted {secondPlayerDamage} damage upon {firstPlayer}.{firstPlayer} has {firstPlayerhealth} health left");
                }

                if (firstPlayerhealth > 0)
                {
                    secondPlayerhealth -= firstPlayerDamage;
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (firstPlayerhealth <= 0)
                        Console.WriteLine(
                            $"{firstPlayer} inflicted {firstPlayerDamage} damage upon {secondPlayer}.{secondPlayer} is dead");
                    else
                        Console.WriteLine(
                            $"{firstPlayer} inflicted {firstPlayerDamage} damage upon {secondPlayer}.{secondPlayer} has {secondPlayerhealth}");
                }
            }

           
            if (firstPlayerhealth >= 1 && secondPlayerhealth <= 1)
                Console.WriteLine($"{firstPlayer} has won");
            else
                Console.WriteLine($"{secondPlayer} has won");
           
        }
    }
}
