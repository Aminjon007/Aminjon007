namespace Lesson3;

class Program
{
    static void zadanie2()
    {
        
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a != b)
        {
            a++;
            b++;
        }
        else
        {
            a = 0;
            b = 0;
        }

        Console.WriteLine(a);
        Console.WriteLine(b);
    }

    static void zadanie3()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter operation: ");
        string op = Console.ReadLine();
        switch (op)
        {
            case "+":
                Console.WriteLine("result= " + (a + b));
                break;
            case "-":
                Console.WriteLine("result= " + (a - b));
                break;
            case "*":
                Console.WriteLine("result= " + a * b);
                break;
            case "/":
                if (a != 0 || b != 0)
                {
                    Console.WriteLine("result= " + a / b);
                }
                else Console.WriteLine("error");

                break;
            default:
                Console.WriteLine("error");
                break;
        }
    }

    static void zadanie4()
    {
        Console.Write("Enter  number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a >= 0 && a <= 14) Console.WriteLine($"0<{a}<14");
        if (a >= 15 && a <= 35) Console.WriteLine($"19<{a}<35");
        if (a >= 36 && a <= 50) Console.WriteLine($"36<{a}<50");
        if (a >= 51 && a <= 100) Console.WriteLine($"55<{a}<100");
    }

    static void Main(string[] args)
    {
        zadanie2();
        zadanie3();
        zadanie4();
    }
}