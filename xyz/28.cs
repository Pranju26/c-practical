using System;

class OperatorsDemo
{
    static void Main()
    {
        int a = 10, b = 5;

        // Arithmetic Operators
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));
        Console.WriteLine("a % b = " + (a % b));

        // Relational Operators
        Console.WriteLine("\nRelational Operators:");
        Console.WriteLine("a > b : " + (a > b));
        Console.WriteLine("a < b : " + (a < b));
        Console.WriteLine("a == b : " + (a == b));
        Console.WriteLine("a != b : " + (a != b));

        // Logical Operators
        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine("(a > 5 && b < 10) : " + (a > 5 && b < 10));
        Console.WriteLine("(a < 5 || b < 10) : " + (a < 5 || b < 10));
        Console.WriteLine("!(a == b) : " + !(a == b));
    }
}