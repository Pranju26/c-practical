using System;

class ArmstrongNumber
{
    static void Main()
    {
        int number, remainder, result = 0, originalNumber;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        originalNumber = number;

        while (number != 0)
        {
            remainder = number % 10;
            result += remainder * remainder * remainder;
            number /= 10;
        }

        if (result == originalNumber)
            Console.WriteLine(originalNumber + " is an Armstrong number.");
        else
            Console.WriteLine(originalNumber + " is not an Armstrong number.");
    }
}