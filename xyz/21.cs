using System;

class GcdLcm
{
    static void Main()
    {
        int num1, num2, gcd, lcm, i;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= num1 && i <= num2; i++)
        {
            if (num1 % i == 0 && num2 % i == 0)
            {
                gcd = i;
            }
        }

        gcd = i - 1;
        lcm = (num1 * num2) / gcd;

        Console.WriteLine("GCD = " + gcd);
        Console.WriteLine("LCM = " + lcm);
    }
}