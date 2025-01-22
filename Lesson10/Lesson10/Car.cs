namespace Lesson10;

public class Car:IMovable   
{
    public void Move(int speed) => Console.WriteLine($"Car is moving with speed {speed}");
}