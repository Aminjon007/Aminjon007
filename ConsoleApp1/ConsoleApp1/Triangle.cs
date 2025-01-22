namespace ConsoleApp1;

public class Triangle(int a,int b,int c) : Shape
{
    public override void CalculateArea()
    {
        double s=0.5*a*b;
        Console.WriteLine($"Area of Triangle: {s}");
    }

    public override void CalculatePerimeter()
    {
        double P = a + b + c;
        Console.WriteLine($"Perimeter of Triangle: {P}");
    }
}