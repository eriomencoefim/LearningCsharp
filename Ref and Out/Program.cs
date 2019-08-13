using System;
using System.Runtime.InteropServices;

namespace Ref_and_Out
{
    class Program
    {
        static void Main()
        {
            //double area = 0;
            //AreaAndPerimOfRectangle(3, 2.4, out area, out double perimetru);
           
            //Console.WriteLine($"Area: {area}\nPerimetru: {perimetru}");

            string name = "john";
            FixName(ref name);
            Console.WriteLine($"Fix name: {name}");

            string institution;
            if (TryGetInstitution(33, out institution))
            {
                Console.WriteLine($"institution: {institution}");
            }
            else
            {
                Console.WriteLine($"Error: couldn't find insitution, value is {institution}");
            }

            //FaraOut(age);
            //Console.WriteLine($"FaraOut: {age}");
        }


        private static void FixName(ref string name)
        {
            if (!name.StartsWith("Mr"))
            {
                name = "Mr" + name;
;           }
        }

        private static bool TryGetInstitution(int age, out string institution)
        {
            if (age < 18)
            {
                institution = "Scoala";
                return true;
            }
            
            if(age > 18 && age < 21)
            {
                institution = "Universitate";
                return true;
            }

            institution = "Unknown";
            return false;
        }

       


        private static void AreaAndPerimOfRectangle(double L, double l , out double area,out double perimetru)
        {
            area = L * l;
            perimetru = 2 * L + 2 * l;
        }
    }
}
