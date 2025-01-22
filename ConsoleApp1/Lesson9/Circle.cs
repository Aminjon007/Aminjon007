namespace ConsoleApp1;

public class Circle(double p) :Shape
{
    double p = 3.14;
    public override void CalculateArea()
    {

        double s = p * double.Pow(p, 2);
        Console.WriteLine($"Area of Circle: {s}");
    }

    public override void CalculatePerimeter()
    {
        double P=2*p*3.14;
        Console.WriteLine($"Perimeter of Circle: {P}");
    }
}