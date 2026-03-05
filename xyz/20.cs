using System;

class PrimeNumber
{
    static void Main()
    {
        int number, i, count = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        if (count == 2)
            Console.WriteLine(number + " is a Prime Number.");
        else
            Console.WriteLine(number + " is not a Prime Number.");
    }
}