using System;

namespace _02.IntegerDataTypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input the drive letter: ");
            char driveLetter = (char)Console.Read();
            Console.WriteLine("Input the folder path: ");
            string folderPath = Console.ReadLine();
            Console.WriteLine("Input the file name: ");
            string fileName = Console.ReadLine();
            Console.WriteLine($"{driveLetter}:\\{folderPath}\\{fileName}");



    }
    }
}
