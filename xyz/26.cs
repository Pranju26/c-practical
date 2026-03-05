using System;

class TypeCastingDemo
{
    static void Main()
    {
        // Implicit Casting (smaller type to larger type)
        int num = 10;
        double d = num;

        Console.WriteLine("Implicit Casting:");
        Console.WriteLine("Integer value = " + num);
        Console.WriteLine("Converted to Double = " + d);

        // Explicit Casting (larger type to smaller type)
        double x = 9.78;
        int y = (int)x;

        Console.WriteLine("\nExplicit Casting:");
        Console.WriteLine("Double value = " + x);
        Console.WriteLine("Converted to Integer = " + y);
    }
}