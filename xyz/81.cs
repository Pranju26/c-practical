using System;

class Program
{
    static int SumArray(int[] arr)
    {
        int sum = 0;

        foreach (int num in arr)
        {
            sum += num;
        }

        return sum;
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40 };

        Console.WriteLine("Sum of array elements = " + SumArray(numbers));
    }
}