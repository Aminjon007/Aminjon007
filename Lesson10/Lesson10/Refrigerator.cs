namespace Lesson10;

public class Refrigerator: Appliance    
{
    public override void TurnOn()
    {
        Console.WriteLine("Refrigerator is turning on");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Refrigerator is turning off");
    }
}