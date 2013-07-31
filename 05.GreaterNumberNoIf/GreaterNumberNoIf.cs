//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class GreaterNumberNoIf
{
    static void Main()
    {
        Console.Write("Enter the first number:\n=> ");
        int firstValue = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:\n=> ");
        int secondValue = int.Parse(Console.ReadLine());
        int greaterValue = Math.Max(firstValue, secondValue);

        Console.WriteLine("Greater number is: {0}", greaterValue);
    }
}
