using System;

class ConditionalStatements
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        // if statement
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }

        // if-else statement
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }

        // switch statement
        switch (number)
        {
            case 1:
                Console.WriteLine("You entered One.");
                break;
            case 2:
                Console.WriteLine("You entered Two.");
                break;
            default:
                Console.WriteLine("Number is not 1 or 2.");
                break;
        }
    }
}