using System;

class Sample
{
    private int[] arr = new int[5];

    public int this[int index]
    {
        get { return arr[index]; }
        set { arr[index] = value; }
    }
}

class Program
{
    static void Main()
    {
        Sample obj = new Sample();

        obj[0] = 10;
        obj[1] = 20;
        obj[2] = 30;

        Console.WriteLine(obj[0]);
        Console.WriteLine(obj[1]);
        Console.WriteLine(obj[2]);
    }
}