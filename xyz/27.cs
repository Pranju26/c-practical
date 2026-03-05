using System;

class ConstantReadonlyDemo
{
    const double PI = 3.14;     // Constant variable
    readonly int value;         // Readonly variable

    public ConstantReadonlyDemo(int v)
    {
        value = v;   // readonly can be assigned in constructor
    }

    static void Main()
    {
        ConstantReadonlyDemo obj = new ConstantReadonlyDemo(10);

        Console.WriteLine("Constant value of PI = " + PI);
        Console.WriteLine("Readonly value = " + obj.value);
    }
}