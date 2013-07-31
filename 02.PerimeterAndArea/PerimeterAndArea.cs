//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class PerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the radius 'r':\n=> ");
        double radius = double.Parse(Console.ReadLine());
        if (radius > 0)
        {
            double pi = Math.Round(Math.PI, 2);
            double perimeterResult = (2 * pi) * radius;
            Console.WriteLine("Using the formula for Perimeter:  2 * {0} * {1} = {2}\nP = {2}", pi, radius, perimeterResult);
            double areaResult = pi * (radius * radius);
            Console.WriteLine("Using the formula for Area: {0} * ({1} * {1}) = {2}\nA = {2}", pi, radius, areaResult);
        }
        else
        {
            Console.WriteLine("Enter radius > 0 !");
        }
    }
}
