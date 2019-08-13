using System;

namespace PlaceHolders
{
    class Program
    {
        static void Main()
        {
            string name = "Efim";
            string surname = " Eriomenco";
            WriteLinePlaceHolder("[0] [1]" , name,surname);
            
        }

        static void WriteLinePlaceHolder(string text, params string[] variables)
        {
            string newText = string.Empty;
                for (int i=0; i < text.Length; i++)
                if (text[i].ToString() == "[")
                {
                    newText += variables[int.Parse(text[i+1].ToString())];
                    i = i + 2;
                }
                else
                {
                    newText = newText + text[i];
                }

                Console.WriteLine($"{newText}");
        }

    }
}
