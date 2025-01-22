namespace ConsoleApp1;

public class Rectangle(int a,int b) : Shape
{
    public override void CalculateArea()
    {
        double s = a*b;
        Console.WriteLine($"Area of Rectangle: {s}");
    }

    public override void CalculatePerimeter()
    {
        double P = 2 * (a + b);
        Console.WriteLine($"Perimeter of Rectangle: {P}");
    }
}