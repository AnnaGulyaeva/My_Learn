// Перевернутое число

// Задача: дано трехзначное число. Перевернуть число и вывести.

// Формат входных данных: на вход дается трехзначное число, не оканчивающее на ноль.

// Формат выходных данных: вывести перевернутое число.

using System;

public class MainClass
{
    public static void Main()
    {
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(a % 10 + "" +a % 100 / 10 + "" + a / 100);
    }
}
