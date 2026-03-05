using System;

class TupleDemo
{
    static void Main()
    {
        var student = (Id: 1, Name: "Amit", Age: 20);

        Console.WriteLine(student.Id);
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Age);
    }
}