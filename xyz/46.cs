using System;

struct Student
{
    public int id;
    public string name;
}

class StructDemo
{
    static void Main()
    {
        Student s;

        s.id = 1;
        s.name = "Rahul";

        Console.WriteLine("ID = " + s.id);
        Console.WriteLine("Name = " + s.name);
    }
}