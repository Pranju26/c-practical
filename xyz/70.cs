using System;

class CompareStrings
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "Hello";

        if (str1.Equals(str2))
            Console.WriteLine("Strings are equal");
        else
            Console.WriteLine("Strings are not equal");
    }
}