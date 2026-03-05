using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Hello@123#World!";

        string result = Regex.Replace(text, "[^a-zA-Z0-9]", "");

        Console.WriteLine("After removing special characters:");
        Console.WriteLine(result);
    }
}