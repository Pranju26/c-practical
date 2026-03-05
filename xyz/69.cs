using System;
using System.Text;

class StringBuilderDemo
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");

        sb.Append(" World");
        sb.Append(" in C#");

        Console.WriteLine(sb.ToString());
    }
}