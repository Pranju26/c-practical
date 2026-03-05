using System;

class AreaOfRectangle
{
    static void Main()
    {
        double length, width, area;

        Console.Write("Enter the length of the rectangle: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        width = Convert.ToDouble(Console.ReadLine());

        area = length * width;

        Console.WriteLine("Area of the Rectangle = " + area);
    }
}