using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Principal Amount (P): ");
        double P = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest (R): ");
        double R = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time in Years (T): ");
        double T = Convert.ToDouble(Console.ReadLine());

        double SI = (P * R * T) / 100;

        Console.WriteLine("Simple Interest = " + SI);
    }
}