using System;

class ArraySort
{
    static void Main()
    {
        int[] arr = {5, 2, 8, 1, 9};

        Array.Sort(arr);

        Console.WriteLine("Sorted Array:");

        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}