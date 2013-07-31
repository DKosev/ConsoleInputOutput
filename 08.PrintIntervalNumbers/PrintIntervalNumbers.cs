//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class PrintIntervalNumbers
{
    static void Main()
    {
        Console.Write("Enter a value to get all the numbers in the interval [1..n]:\nn = ");
        int nValue = int.Parse(Console.ReadLine());
        int startPosition = 0;
        for (int i = 0; i < nValue; i++)
        {
            startPosition++;
            Console.WriteLine(startPosition);
        }
    }
}
