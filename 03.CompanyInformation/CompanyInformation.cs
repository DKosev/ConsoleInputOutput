//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyInformation
{
    static void Main()
    {
        //Company Information
        Console.WriteLine("Insert the company information trough this form.");
        Console.Write("Enter the company name:\n=> ");
        string companyName = Console.ReadLine();
        Console.Write("Enter the company address:\n=> ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter the company phone number:\n=> ");
        string companyPhone = Console.ReadLine();
        Console.Write("Enter the company fax number:\n=> ");
        string companyFax = Console.ReadLine();
        Console.Write("Enter the company web site:\n=> ");
        string companyWebsite = Console.ReadLine();
        Console.Write("Enter the company manager name:\n=> ");
        string companyManager = Console.ReadLine();

        //The manager information
        Console.WriteLine("\nInsert the company manager information.");
        Console.Write("Enter the manager first name:\n=> ");
        string manFirstName = Console.ReadLine();
        Console.Write("Enter the manager last name:\n=> ");
        string manLastName = Console.ReadLine();
        Console.Write("Enter the manager years:\n=> ");
        byte manAge = byte.Parse(Console.ReadLine());
        Console.Write("Enter the manager phone number:\n=> ");
        string manPhone = Console.ReadLine();

        //Print the company information
        Console.WriteLine("The {0}'s information:", companyName);
        Console.WriteLine("\tName: {0}", companyName);
        Console.WriteLine("\tAddress: {0}", companyAddress);
        Console.WriteLine("\tPhone: {0}", companyPhone);
        Console.WriteLine("\tFax: {0}", companyFax);
        Console.WriteLine("\tWebsite: {0}", companyWebsite);
        Console.WriteLine("\tManager: {0}", companyManager);

        //Print the manager information
        Console.WriteLine("\nThe company manager information:");
        Console.WriteLine("\tFirst name: {0}", manFirstName);
        Console.WriteLine("\tLast Name: {0}", manLastName);
        Console.WriteLine("\tAge: {0}", manAge);
        Console.WriteLine("\tPhone: {0}", manPhone);
    }
}
