using System;

class Program
{
    static void Student(string name, int age, string city)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
    }

    static void Main()
    {
        Student(city: "Pune", name: "Riya", age: 20);
    }
}