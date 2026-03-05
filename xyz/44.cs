using System;

class VarDynamicDemo
{
    static void Main()
    {
        var a = 10;
        dynamic b = 20;

        Console.WriteLine("Var value = " + a);
        Console.WriteLine("Dynamic value = " + b);

        b = "Hello";
        Console.WriteLine("Dynamic changed to string = " + b);
    }
}