using System;

namespace AlignmentsCurrencyDecimalPointETC
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("|Protein Intake Week: 1|");
            Console.WriteLine("|=====================|");
            float firstDay = 80.88557f;
            Console.WriteLine($"|{firstDay,21:N}|");
            float secondDay = 94.56465f;
            Console.WriteLine($"|{secondDay,21:N}|");
            float thirdDay = 78.67893f;
            Console.WriteLine($"|{thirdDay,21:N}|");
            float fourthDay = 88.66654f;
            Console.WriteLine($"|{fourthDay,21:N}|");
            float fifthDay = 88.6466f;
            Console.WriteLine($"|{fifthDay,21:N}|");
            float sixthDay = 76.777f;
            Console.WriteLine($"|{sixthDay,21:N}|");
            float seventhDay = 91.85759f;
            Console.WriteLine($"|{seventhDay,21:N}|");
            Console.WriteLine("|=====================|");

            float i = firstDay + secondDay +thirdDay + fourthDay + fifthDay + sixthDay + seventhDay;

            Console.WriteLine($"|Total:{ i ,15:N}|");
        
       



            //Console.WriteLine($"|Total:{total,15:N}|");



        }
    }
}
