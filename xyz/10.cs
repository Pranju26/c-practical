using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nBefore Swapping: a = " + a + ", b = " + b);

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After Swapping:  a = " + a + ", b = " + b);
    }
}