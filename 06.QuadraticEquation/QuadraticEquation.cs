//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;
using System.Threading;
using System.Globalization;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        Console.Write("Enter the 'a' coefficient:\n=> ");
        double aValue = double.Parse(Console.ReadLine());
        Console.Write("Enter the 'b' coefficient:\n=> ");
        double bValue = double.Parse(Console.ReadLine());
        Console.Write("Enter the 'c' coefficient:\n=> ");
        double cValue = double.Parse(Console.ReadLine());
        double sqrt = bValue * bValue - (4 * aValue * cValue);
        if (sqrt > 0)
        {
            double x1 = (-bValue + Math.Sqrt(sqrt)) / (2 * aValue);
            double x2 = (-bValue - Math.Sqrt(sqrt)) / (2 * aValue);
            Console.WriteLine("The are two solutions:");
            Console.WriteLine("x1 = {0:F2}\nx2 = {1:F2}", x1, x2);
        }
        else if (sqrt == 0)
        {
            double x = -bValue / (2 * aValue);
        }
        else
        {
            if (sqrt < 0)
            {
                Console.WriteLine("There are no real roots!");
            }
        }        
    }
}