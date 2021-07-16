// Число сотен числа

// Задача: дано натуральное целое число. Найдти число сотен (то есть третью справа цифру).

// Формат входных данных: на вход дается натуральное число, не превосходящее 10000 10000 10000.

// Формат выходных данных: вывести одно целое число - число сотен.

using System;

public class MainClass
{
    public static void Main()
    {
        int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        int b = a % 1000;
        int c = b % 100;
        int d = (b - c) / 100;
        Console.WriteLine(d);
    }
}
