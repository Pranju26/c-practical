using System;

class Program
{
    static void PrintNumbers(int n)
    {
        if (n == 0)
            return;

        PrintNumbers(n - 1);
        Console.WriteLine(n);
    }

    static void Main()
    {
        Console.WriteLine("Numbers from 1 to 5:");
        PrintNumbers(5);
    }
}