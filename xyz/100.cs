using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        Console.WriteLine("Array Elements:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        GC.Collect();

        Console.WriteLine("Garbage Collection Invoked");
    }
}