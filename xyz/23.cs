using System;

class AreaOfCircle
{
    static void Main()
    {
        double radius, area;

        Console.Write("Enter the radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());

        area = 3.14 * radius * radius;

        Console.WriteLine("Area of the Circle = " + area);
    }
}