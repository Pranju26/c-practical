using System;

class Program
{
    static void Main()
    {
        string sentence = "C sharp programming language";

        string[] words = sentence.Split(' ');

        Console.WriteLine("Words in the sentence:");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}