using System;

namespace Logical_Operations
{
    class Program
    {
        static void Main()
        {
        //    string username ="prettyboy66";

        //    bool IstheLongerThanSixCharacters = username.Length > 6;

        //    char firstLetter = username[0];
        //    //bool IsTheFirstCharacterCapital = Char.IsUpper(firstLetter);

         
        //    int firstletterAsNumber = (int) firstLetter;
        //    bool IsTheFirstCharacterCapital = firstletterAsNumber >= 65 && firstletterAsNumber <= 90;
        //    Console.WriteLine($"IsTheFirstCharacterCapital: {IsTheFirstCharacterCapital}");

        //    bool isUsernameValid = IstheLongerThanSixCharacters || IsTheFirstCharacterCapital;

        //    Console.WriteLine($"result: {isUsernameValid}"); 

             string username = "dre";
             bool IstheUsernameLenghtisBetween5to14 = username.Length >= 5 && username.Length <= 14;
             bool IsTheFirstCharacterSmall =!Char.IsUpper(username[0]);
             bool isNotAdmin = username != "admin";
             bool isNotNumber = !((int) username[0] >= 48 && (int) username[0] <= 57);


             Console.WriteLine(
                 (IstheUsernameLenghtisBetween5to14 && IsTheFirstCharacterSmall && isNotAdmin) || 
                 (IstheUsernameLenghtisBetween5to14 && isNotNumber));

        }
    }
}
