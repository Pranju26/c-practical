using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Span<int> span = numbers;
        span[0] = 100;

        ReadOnlySpan<int> readOnlySpan = numbers;

        Console.WriteLine("Span first value: " + span[0]);
        Console.WriteLine("ReadOnlySpan second value: " + readOnlySpan[1]);
    }
}