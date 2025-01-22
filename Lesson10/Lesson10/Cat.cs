namespace Lesson10;

public class Cat: Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing");
    }

    public override void Speak()
    {
        Console.WriteLine("Cat is speaking");
    }
    
    public override void Eat()
    {
        Console.WriteLine("Cat is eating");
    }

    public override void Sleep()
    {
        Console.WriteLine("Cat is sleeping");
    }

}