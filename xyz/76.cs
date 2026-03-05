using System;

class Program
{
    static void UsingRef(ref int x)
    {
        x = x + 10;
    }

    static void UsingOut(out int y)
    {
        y = 50;
    }

    static void Main()
    {
        int a = 20;
        UsingRef(ref a);
        Console.WriteLine("Value using ref: " + a);

        int b;
        UsingOut(out b);
        Console.WriteLine("Value using out: " + b);
    }
}