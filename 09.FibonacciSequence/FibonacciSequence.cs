//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class FibonacciSequence
{
    static void Main()
    {
        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal result = 0;
        decimal start = 1;
        decimal position;
        for (int i = 0; i < 100; i++)
        {
            result = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = result;
            position = start++;
            Console.WriteLine("{0} => {1}", position, result);
        }
    }
}