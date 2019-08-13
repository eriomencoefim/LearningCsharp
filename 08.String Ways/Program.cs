using System;

namespace _08.String_Ways
{
    class Program
    {
        static void Main()
        {
            string numeleCaracterului = "Mike ";
            string spellName = " ak-47 ";
            int damagetaken = 101;

            string damageReport = string.Format("The {0} charater took {1} damage from {2},and the character {0} is now dead",numeleCaracterului,spellName,damagetaken);

            Console.WriteLine(damageReport);
        }
    }
}
