using System;
namespace Lesson4;

class Program   
{
    static void Main()
    {
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        int sum = 0;
        for (int i = a; i < b; i++)sum += i;
        Console.WriteLine("Sum="+sum);
        //______________________________________
        int c = Convert.ToInt16(Console.ReadLine());
        int d = Convert.ToInt16(Console.ReadLine());
        for (int i = a; i < b; i++)if (i%2!=0) Console.WriteLine(i);
        
        //______________________________________
        Console.WriteLine("Choose the type of figure \n equilateral triangle\nright-angled triangle\nRectangle\nRhomb");
        string figure = Console.ReadLine();
        switch (figure)
        {
            case "equilateral triangle":
                Console.WriteLine("*");
                Console.WriteLine("* *");
                Console.WriteLine("*  *");
                Console.WriteLine("*    *");
                Console.WriteLine("*     *");
                Console.WriteLine("*      *");
                Console.WriteLine("*       *");
                Console.WriteLine("*        *");
                Console.WriteLine("***********");
                break;
            case "triangle":
                Console.WriteLine("    *"); 
                Console.WriteLine("   ***"); 
                Console.WriteLine("  *****"); 
                Console.WriteLine(" *******"); 
                Console.WriteLine("*********"); 
                break;
            case "Rectangle":
                Console.WriteLine("**************");
                Console.WriteLine("*            *");
                Console.WriteLine("*            *");
                Console.WriteLine("*            *");
                Console.WriteLine("**************");
                break;
            case "Rhomb":
                Console.WriteLine("    *"); 
                Console.WriteLine("   ***"); 
                Console.WriteLine("  *****"); 
                Console.WriteLine(" *******"); 
                Console.WriteLine("*********");
                Console.WriteLine(" *******"); 
                Console.WriteLine("  *****"); 
                Console.WriteLine("   ***"); 
                Console.WriteLine("    *"); 
                break;
            
        }
        //_____________________________________
        int p = Convert.ToInt16(Console.ReadLine());
        int summ = 1000;
        for (int i = 0; i < 12; i++)
        {
            summ += (p * summ) / 100;
        }

        Console.WriteLine("Sum= "+summ);
    }
}