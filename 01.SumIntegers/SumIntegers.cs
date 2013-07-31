//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("You have to add three numbers to get their sum.");
        Console.Write("Add the first number:\n=> ");
        int firstValue = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:\n=> ");
        int secondValue = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number:\n=> ");
        int thirdValue = int.Parse(Console.ReadLine());
        int result = firstValue + secondValue + thirdValue;
        Console.WriteLine("The result: {0} + {1} + {2} = {3}", firstValue, secondValue, thirdValue, result);
    }
}
