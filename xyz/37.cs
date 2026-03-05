using System;

class PowerOfNumber
{
    static void Main()
    {
        int number, power, result = 1;

        Console.Write("Enter number: ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter power: ");
        power = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= power; i++)
        {
            result = result * number;
        }

        Console.WriteLine("Result = " + result);
    }
}