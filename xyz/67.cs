using System;

class RemoveSpaces
{
    static void Main()
    {
        string str = "Hello World in CSharp";

        string result = str.Replace(" ", "");

        Console.WriteLine("String without spaces = " + result);
    }
}