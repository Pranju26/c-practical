using System;

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    static void Main()
    {
        Console.WriteLine("Sum of two integers: " + Add(10, 20));
        Console.WriteLine("Sum of two doubles: " + Add(10.5, 20.5));
        Console.WriteLine("Sum of three integers: " + Add(10, 20, 30));
    }
}