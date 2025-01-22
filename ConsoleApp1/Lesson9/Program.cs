using System;

namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        /*Shape circle = new Circle(5);
        circle.CalculateArea();
        circle.CalculatePerimeter();
        Console.WriteLine();
        Shape rectangle = new Rectangle(5, 7);
        rectangle.CalculateArea();
        rectangle.CalculatePerimeter();
        Console.WriteLine();
        Shape triangle = new Triangle(2, 4, 6);
        triangle.CalculateArea();
        triangle.CalculatePerimeter();*/

        Shape[] shapes = new Shape[]
        {
            new Circle(5),
            new Rectangle(5, 7),
            new Triangle(2, 4, 6)
        };
        foreach (Shape shape in shapes)
        {
            shape.CalculateArea();
            shape.CalculatePerimeter();
            Console.WriteLine();
        }
    }
}