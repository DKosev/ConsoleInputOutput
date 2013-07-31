//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class NumbersBetweenInts
{
    static void Main()
    {
        Console.Write("Enter two positive numbers:\nFirst => ");
        int firstValue = int.Parse(Console.ReadLine());
        Console.Write("Second => ");
        int secondValue = int.Parse(Console.ReadLine());
        int counter = 0;

        if (firstValue <= 0 || secondValue <= 0)
        {
            Console.WriteLine("The both numbers have to be positive!");
        }
        else
        {
            for (int i = firstValue; i <= secondValue; i++)
			{
			    if (i % 5 == 0)
                {
                    counter++;
                }
			}
            Console.WriteLine("There are {0} numbers between {1} and {2} than can be devided by 5 without a reminder.", counter, firstValue, secondValue);
        }
    }
}
