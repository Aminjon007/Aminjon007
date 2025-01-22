using System;

namespace Lesson10;

class Program
{
    static void Main()
    {
        IMovable car = new Car();
        car.Move(230);
        Console.WriteLine();

        IMovable robot = new Robot();
        robot.Move(345);
        Console.WriteLine();

        Appliance appliance = new Refrigerator();
        appliance.TurnOn();
        appliance.TurnOff();
        Console.WriteLine();

        Appliance appliance1 = new WashingMachine();
        appliance1.TurnOn();
        appliance1.TurnOff();
        Console.WriteLine();

        Cat cat = new Cat();
        cat.Eat();
        cat.Sleep();
        cat.Speak();
        cat.Meow();
        Console.WriteLine();

        Dog dog = new Dog();
        dog.Eat();
        dog.Sleep();
        dog.Speak();
        dog.Bark();
        Console.WriteLine();
    }
}