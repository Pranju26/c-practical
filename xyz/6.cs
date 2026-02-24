using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine(num + " is a POSITIVE number");
        }
        else if (num < 0)
        {
            Console.WriteLine(num + " is a NEGATIVE number");
        }
        else
        {
            Console.WriteLine("The number is ZERO");
        }
    }
}