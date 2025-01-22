namespace Lesson10;

public class Dog:Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }

    public override void Speak()
    {
        Console.WriteLine("Dog is speaking");
    }

    public override void Eat()
    {
        Console.WriteLine("Dog is eating");
    }

    public override void Sleep()
    {
        Console.WriteLine("Dog is sleeping");
    }
}