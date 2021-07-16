// Задача: дано натуральное число. Найти сумму последних трех цифр.

// Формат входных данных: на вход дается натуральное число, не превосходящее 109.10^9.109.

// Формат выходных данных: вывести одно целое число - сумму последних трех цифр.

using System;

public class MainClass
{
    public static void Main()
    {
        int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        int a = n % 1000 / 100;
        int b = n % 100 / 10;
        int c = n % 10;
        Console.WriteLine(a + b + c);
    }
}
