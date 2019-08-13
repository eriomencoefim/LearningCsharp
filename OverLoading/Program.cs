using System;

namespace OverLoading
{
    class Program
    {
        static void Main()
        {
            double rectangleArea = CalculateAreaOfRectangle(4.9, 5.4);
            double squareArea = CalculateAreaOfSquare(8.5);
            double triangleArea = CalculateAreOfTriangle(7.5, 5.3, 3.6);

            Console.WriteLine($"rectangleArea: {rectangleArea}");
            Console.WriteLine($"squareArea: {squareArea}");
            Console.WriteLine($"triangleArea: {triangleArea}");
        }

       

        private static double CalculateAreOfTriangle(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double f = s * (s - a) * (s - b) * (s - c);
            double area = Math.Sqrt(f);
            return area;
            
        }

        private static double CalculateAreaOfSquare(double l)
        {
            return l * l;
        }

        private static double CalculateAreaOfRectangle(double L, double l)
        {
            return L * l;
        }

    }
}
