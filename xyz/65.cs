using System;

class WordCount
{
    static void Main()
    {
        string str = "C sharp programming language";

        int count = str.Split(' ').Length;

        Console.WriteLine("Number of words = " + count);
    }
}