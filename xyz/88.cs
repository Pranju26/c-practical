using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$";

        if (Regex.IsMatch(password, pattern))
            Console.WriteLine("Strong Password");
        else
            Console.WriteLine("Weak Password");
    }
}