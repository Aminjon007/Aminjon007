namespace Lesson10;

public class Robot:IMovable 
{
    public void Move(int speed)
    {
        Console.WriteLine($"Robot is moving with speed {speed}");
    }
}