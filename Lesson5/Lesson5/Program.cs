﻿using System;

namespace Lesson4;

class Program
{
    static void Main()
    {
        Random random = new Random();
        
        int min = 0;
        int max = 9999;
        
        List<int> chetnie = new List<int>();
        List<int> neChetnie = new List<int>();
        
        List<int> polindrom = new List<int>();
        
        int[,] arr = new int[7, 4];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                // Creation
                int a = random.Next(1, 9999);
                arr[i, j] = a;
                Console.Write(arr[i, j] + "\t");
                // Chetni | Nechetni
                if (arr[i, j] % 2 == 0) chetnie.Add(arr[i, j]);
                if (arr[i, j] % 2 != 0) neChetnie.Add(arr[i, j]);
                //  Max | Min
                if (arr[i, j] > max) max = arr[i, j];
                if (arr[i, j] < min) min = arr[i, j];
                // Polindrom
                int len4s = arr[i, j] % 10;
                int len4m = (arr[i, j] / 100) % 10;
                int len4n = (arr[i, j] / 10) % 10;
                int len4e = arr[i, j] / 1000;
                int len3s = arr[i, j] % 10;
                int len3e = arr[i, j] / 100;
                if (arr[i, j] >= 1000 && arr[i, j] <= 9999 && len4s == len4e &&len4m==len4n) polindrom.Add(arr[i, j]);
                if (arr[i, j] >= 100 && arr[i, j] <= 999 && len3s == len3e) polindrom.Add(arr[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("__________________________________________________");
        foreach (int el in chetnie) Console.WriteLine("Chetni:"+el);
        Console.WriteLine("__________________________________________________");
        foreach (int el in neChetnie) Console.WriteLine("Ne Chetni:"+el);
        Console.WriteLine("__________________________________________________");
        foreach (int el in polindrom) Console.WriteLine("Polindrom:"+el);
        Console.WriteLine("__________________________________________________");
        Console.WriteLine("Max="+max);
        Console.WriteLine("__________________________________________________");
        Console.WriteLine("Min="+min);

        /*int siz = Convert.ToInt16(Console.ReadLine());
        int[] ar = new int[4];
        ar = [1, 2, 3, 4];

        int[] ar1 = new int[ar.Length + siz];
        for (int i = 0; i < ar.Length; i++)
        {
            ar1[i] = ar[i];
        }

        foreach (int el in ar1)
        {
            Console.WriteLine(el);
        }*/
    }
}