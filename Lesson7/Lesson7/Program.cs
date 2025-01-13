using System;
using System.Text;
using DateTime = System.DateTime;

namespace Lesson7;

class Program
{
    static void Main()
    {
        //1
        // str1();
        //2
        //str2_b();
        //3
        //str3();
        //4
        //str4();

        void str1()
        {
            Console.Write("Enter text: ");
            string str = Console.ReadLine();
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'o' || str[i] == 'e' || str[i] == 'i') newStr += '*';
                else newStr += str[i];
            }

            Console.WriteLine(newStr);
        }

        void str2_b()
        {
            string str = Console.ReadLine();
            string[] newStr = str.Split(' ');
            string mstr = "";
            for (int i = 0; i < newStr.Length; i++)
            {
                mstr += newStr[i];
                if (i != newStr.Length - 1) mstr += "*";
            }

            Console.WriteLine(mstr);
        }

        void str2()
        {
            string str = Console.ReadLine();
            Console.WriteLine();
            str = str.Trim();
            string[] newStr = str.Split(' ');
            Console.WriteLine($"It is {newStr.Length} words in Text");

            string max = " ";
            for (int i = 0; i < newStr.Length; i++)
                if (newStr[i].Length > max.Length)
                    max = newStr[i];
            Console.WriteLine($"The longest word is {max}\n");

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int codepoint = Convert.ToInt16(str[i]);
                if (codepoint >= 48 && codepoint <= 57) count++;
            }

            Console.WriteLine($"It is {count} numbers in text.");
        }

        void str3()
        {
            DateTime date = DateTime.UtcNow;
            Console.WriteLine("Day of Week:" + date.DayOfWeek);
            DayOfWeek day = date.DayOfWeek;
            DayOfWeek mon = DayOfWeek.Monday;
            int day1 = Convert.ToInt16(mon);
            int day2 = Convert.ToInt16(day);
            Console.WriteLine($"It is {day1-day2} days left to Monday");
        }

        void str4()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 1000000; i++)
            {
                stringBuilder.Append("A");
            }

            Console.WriteLine(stringBuilder);
        }
    }
}