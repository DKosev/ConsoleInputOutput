//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class AccuracySum
{
    static void Main()
    {
        double value = 1d;
        for (double i = 2; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                value += 1 / i;
            }
            else
            {
                value -= 1 / i;
            }
        }
        Console.WriteLine("The result is: {0:0.000}", value);
    }
}
