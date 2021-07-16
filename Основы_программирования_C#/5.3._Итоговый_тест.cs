// n-ый член арифметической прогрессии

// Входные данные: программа получает на вход натуральные числа a1, d d d и n n n, каждое из которых не превышает 10000 10000 10000.

// Выходные данные: вывести n-ый член арифметический прогрессии.

using System;

public class MainClass
{
    public static void Main()
    {
       int a1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
       int d = Math.Abs(Convert.ToInt32(Console.ReadLine()));
       int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
       int an = a1 + d * (n - 1);
       Console.WriteLine(an);
    }
}
