namespace Lesson10;

public class WashingMachine: Appliance  
{
    public override void TurnOn()
    {
        Console.WriteLine("Washing machine is turning on");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Washing machine is turning off");
    }
}