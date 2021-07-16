// Перестановки цифр(*)

// Задача: дано одно натуральное четырехзначное число. Найти самое большое число, полученное из заданного перестановкой его цифр.  
// Например, если дано число 5239. Из всех перестановок цифр наибольшим будет 9532. 

// Формат входных данных: на вход дается одно натуральное четырехзначное число.

// Формат выходных данных: вывести одно натуральное число - самое большое число, полученное из заданного перестановкой цифр заданного числа. 

using System;

public class MainClass
{
    public static void Main()
    {

            int n = Convert.ToInt32(Console.ReadLine());
            int a = n / 1000;
            int b = n % 1000 / 100;
            int c = n % 100 / 10;
            int d = n % 10;
            int x1 = Math.Max(a, b);
            int x2 = Math.Max(x1, c);
            int x3 = Math.Max(x2, d);
            int y1 = Math.Min(a, b);
            int y2 = Math.Min(y1, c);
            int y3 = Math.Min(y2, d);
            int z1 = Math.Max(a, b);
            int z2 = Math.Max(c, d);
            int z3 = Math.Min(z1, z2);
            int v1 = Math.Min(a, b);
            int v2 = Math.Min(c, d);
            int v3 = Math.Max(v1, v2);
            int c2 = Math.Max(z3, v3);
            int c3 = Math.Min(z3, v3);
            Console.WriteLine(x3 + ""+c2+""+c3+"" + y3);
    }
}
