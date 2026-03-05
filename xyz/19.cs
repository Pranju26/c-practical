using System;

class PrimeRange
{
    static void Main()
    {
        int start, end, i, j, count;

        Console.Write("Enter starting number: ");
        start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter ending number: ");
        end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prime numbers between " + start + " and " + end + " are:");

        for (i = start; i <= end; i++)
        {
            count = 0;

            for (j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    count++;
            }

            if (count == 2)
                Console.WriteLine(i);
        }
    }
}