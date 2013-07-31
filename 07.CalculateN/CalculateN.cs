//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class CalculateN
{
    static void Main()
    {
        Console.Write("Choose how many times you want to enter a number and sum it:\n=> ");
        int nValue = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < nValue; i++)
        {
            int inputValue = int.Parse(Console.ReadLine());
            result += inputValue;
            Console.WriteLine("=> {0}", result);
        }
    }
}
