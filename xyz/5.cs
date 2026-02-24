using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine(num + " is an EVEN number");
        }
        else
        {
            Console.WriteLine(num + " is an ODD number");
        }
    }
}