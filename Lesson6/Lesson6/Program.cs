using System;
namespace Lesson6;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int sum = 0;
        
        SumOfArr(arr);
        Max(ref arr);
        Sum(5);
        Console.WriteLine("Sum= "+sum);
          void Sum(int  a)
        {
            if (a==0)return ;
            sum += a;
            Sum(a-=1);
        }
    }
    
    static void SumOfArr(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine("Sum= "+sum);
    }

    static void Max(ref int[] arr)
    {
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
        }

        Console.WriteLine("Max= "+max);
    }
    
}