using System;

class MergeArrays
{
    static void Main()
    {
        int[] arr1 = {1, 2, 3};
        int[] arr2 = {4, 5, 6};

        int[] arr3 = new int[arr1.Length + arr2.Length];

        arr1.CopyTo(arr3, 0);
        arr2.CopyTo(arr3, arr1.Length);

        Console.WriteLine("Merged Array:");

        foreach (int num in arr3)
        {
            Console.WriteLine(num);
        }
    }
}