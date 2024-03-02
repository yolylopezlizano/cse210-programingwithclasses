using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user name
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        // Ask for the user last name
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        // Show the name in the James Bond format
        Console.WriteLine("Your name is " + lastName + ", " + firstName + " " + lastName + ".");

        Console.ReadLine();
    }
}