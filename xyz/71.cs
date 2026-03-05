using System;

class MethodParameters
{
    static void Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }

    static void Main()
    {
        Add(10, 20);
    }
}