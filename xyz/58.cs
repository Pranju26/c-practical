using System;

class SearchArray
{
    static void Main()
    {
        int[] arr = {10, 20, 30, 40, 50};
        int key = 30;
        bool found = false;

        foreach (int num in arr)
        {
            if (num == key)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine("Element Found");
        else
            Console.WriteLine("Element Not Found");
    }
}