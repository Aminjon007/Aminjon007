using System;

namespace Lesson2;

class Program
{
    static void Main()
    {
        
        // 1
        Console.Write("Enter number: ");
        int a = Convert.ToInt16(Console.ReadLine());
        if (a >= 0) Console.WriteLine(a + "-Polojitelni");
        if (a < 0) Console.WriteLine(a + "-Otrisatelni");
        Console.WriteLine("_____________________________");
        // 2
        Console.Write("Enter number: ");
        int b = Convert.ToInt16(Console.ReadLine());
        if (b % 2 == 0) Console.WriteLine(b + " -Chetni");
        else Console.WriteLine(b + " -NeChetni");
        Console.WriteLine("_______________________________");
        //3
        Console.Write("Enter a number: ");
        int c = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter b number: ");
        int d = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter c number: ");
        int e = Convert.ToInt16(Console.ReadLine());
        int max = 0;
        int min = 0;
        if (c > max) max = c;
        if (max < d) max = d;
        if (max < e) max = e;
        if (c < d) min = c;
        else min = d;
        if (min > e) min = e;
        Console.WriteLine("Min= " + min);
        Console.WriteLine("Max= " + max);
        //4
        Console.WriteLine("_________________________________");
        Console.Write("Enter a number: ");
        int f = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter b number: ");
        int g = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter type of solving: ");
        string tip = Console.ReadLine();
        switch (tip)
        {
            case "+":
                Console.WriteLine("Sum= " + (f + g));
                break;
            case "-":
                Console.WriteLine($"Min= {f - g}");
                break;
            case "*":
                Console.WriteLine($"Proizvod= {f * g}");
                break;
            case "/":
                Console.WriteLine($"Delenie= {f / g}");
                break;
        }
    }
}