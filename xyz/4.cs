using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("Maximum = " + a);
        }
        else if (b > a)
        {
            Console.WriteLine("Maximum = " + b);
        }
        else
        {
            Console.WriteLine("Both numbers are equal");
        }
    }
}