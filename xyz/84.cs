using System;

class Program
{
    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        char[] a = str1.ToCharArray();
        char[] b = str2.ToCharArray();

        Array.Sort(a);
        Array.Sort(b);

        string sorted1 = new string(a);
        string sorted2 = new string(b);

        if (sorted1 == sorted2)
            Console.WriteLine("Strings are Anagrams");
        else
            Console.WriteLine("Strings are not Anagrams");
    }
}