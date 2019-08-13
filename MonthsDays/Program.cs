using System;
using Microsoft.VisualBasic;

namespace MonthsDays
{
    class Program
    {
        static void Main()
        {
            string[] months =
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "Octomber",
                "November", "December"
            };
            string[] weekDays =
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };
            for (int i = 0; i < months.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Month: {months[i]}");
                Console.ResetColor();

                int nrZile = i % 2 == 0 ? 30 : 31;
                int dayOfWeek = 0;
                for (int j = 0; j < nrZile; j++)
                {
                    Console.WriteLine($" {j+1} {weekDays[dayOfWeek]}");
                    if (dayOfWeek == 6)
                    {
                        dayOfWeek = -1;
                    }
                    dayOfWeek++;
                    
                }
               

            }
        }
    }
}
