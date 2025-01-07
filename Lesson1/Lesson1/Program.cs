using System;

namespace Lesson1;
class Program
{
    static void Main(string[] args)
    {
        int age = Convert.ToInt16((Console.ReadLine()));
        Console.WriteLine($"Hello, {age} years old.");
        age = 14;
        Console.WriteLine($"Hello, {age} years old.");
        //___________begin1 
        int a = 13;
        int p = 4 * a;
        Console.WriteLine("P= " + p);
        //___________begin2
        int a1 = 12;
        int s = a1 * a1;
        Console.WriteLine("S= " + s);
        //___________integer1
        int l = 12;
        int l1 = l / 100;
        Console.WriteLine("L= " + l1);
        //___________integer2
        int m = 1234;
        int m1 = m / 1000;
        Console.WriteLine("Ton= " + m1);
    }
}