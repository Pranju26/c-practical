using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int original = num;
        int reverse = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reverse = reverse * 10 + digit;
            num /= 10;
        }

        if (original == reverse)
        {
            Console.WriteLine(original + " is a PALINDROME number");
        }
        else
        {
            Console.WriteLine(original + " is NOT a palindrome number");
        }
    }
}