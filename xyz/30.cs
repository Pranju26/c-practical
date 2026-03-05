using System;

class SwitchCaseDemo
{
    static void Main()
    {
        int choice;

        Console.WriteLine("Enter a number (1-3): ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You selected One");
                break;

            case 2:
                Console.WriteLine("You selected Two");
                break;

            case 3:
                Console.WriteLine("You selected Three");
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}