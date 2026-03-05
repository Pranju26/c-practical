using System;

class CharFrequency
{
    static void Main()
    {
        string str = "program";

        foreach(char ch in str)
        {
            int count = 0;

            foreach(char c in str)
            {
                if(ch == c)
                    count++;
            }

            Console.WriteLine(ch + " = " + count);
        }
    }
}