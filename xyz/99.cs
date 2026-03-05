using System;

class Program
{
    static void Main()
    {
        string str = "Hello";

        str.Concat(" World");

        Console.WriteLine("After Concat: " + str);

        str = str + " World";

        Console.WriteLine("After Modification: " + str);
    }
}