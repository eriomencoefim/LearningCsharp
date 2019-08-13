using System;
using System.ComponentModel.Design;

namespace Conditional_statement
{
    class Program
    {
        static void Main()
        {
            //1.
            //string nameOfPlayer =  " John ";
            //int killedEnemies = 95;
            //int score = 0;
            //int bonusScore = 0;


            //if (killedEnemies == 100)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Congratulations!You've killed all players");
            //}
            //else if (killedEnemies >= 75 && killedEnemies <= 99)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine($"Congratulations{nameOfPlayer}!You've killed {killedEnemies} players");
            //}
            //else if (killedEnemies >= 50 && killedEnemies <= 74) 
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkYellow;
            //    Console.WriteLine($"Congratulations{nameOfPlayer}!You've killed {killedEnemies} players");
            //}
            //else if (killedEnemies < 50)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"Oh no{nameOfPlayer}!You've killed less than 50 players| KILLS={killedEnemies} |,you've lost the game!");
            //}
            //2.
            //float x = 2;
            //float y = 2;
            //int radius = 4;
            //double distanta = Math.Sqrt(Math.Pow(x , 2) + Math.Pow(y , 2));
            //if(distanta < radius )
            //{
            //    Console.WriteLine($"The {distanta} , it is inside the radius ");
            //}
            //else if (distanta > radius)

            //{
            //    Console.WriteLine($"The {distanta} , it is outside the radius");
            //}
            Console.WriteLine("Put the length in metters:");
            float metri = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose the solution that you want to convert : microm,mm,cm,dm,km:");
            string unitOfMeasure = Console.ReadLine();
            float rezultat;
            if (unitOfMeasure == "microm")
            {
                rezultat = metri * 1000000;
                Console.WriteLine($"{rezultat}microm");
            }

            if (unitOfMeasure == "mm")
            {
                rezultat = metri * 1000;
                Console.WriteLine($"{rezultat}mm");
            }

            if (unitOfMeasure == "cm")
            {
                rezultat = metri * 100;
                Console.WriteLine($"{rezultat}cm");
            }
            if (unitOfMeasure == "dm")
            {
                rezultat = metri * 10;
                Console.WriteLine($"{rezultat}dm");
            }
            if (unitOfMeasure == "km")
            {
                rezultat = metri / 1000;
                Console.WriteLine($"{rezultat}km");
            }
            else
            {
                Console.WriteLine($"Ati ales o unitate de masura inexistenta{unitOfMeasure}");
            }
            
           


        }
    }
}
