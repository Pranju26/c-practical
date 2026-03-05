using System;

class ArrayMaxMin
{
    static void Main()
    {
        int[] arr = {12, 45, 7, 89, 23};

        int max = arr[0];
        int min = arr[0];

        foreach (int num in arr)
        {
            if (num > max)
                max = num;

            if (num < min)
                min = num;
        }

        Console.WriteLine("Largest = " + max);
        Console.WriteLine("Smallest = " + min);
    }
}