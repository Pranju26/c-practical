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

        // Calculate Amount
        double A = P * Math.Pow((1 + R / 100), T);

        // Calculate Compound Interest
        double CI = A - P;

        Console.WriteLine("Compound Interest = " + CI);
        Console.WriteLine("Total Amount (A) = " + A);
    }
}