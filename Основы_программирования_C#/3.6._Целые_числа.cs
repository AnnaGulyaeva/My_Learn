// Сумма цифр

// Задача: дано трехзначное число. Найти сумму его цифр.

// Формат входных данных: на вход дается трехзначное число.

// Формат выходных данных: вывести одно целое число - сумму цифр введенного числа.

using System;

public class MainClass
{
    public static void Main()
    {
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(a / 100 + (a % 100) / 10 + a % 10);
    }
}
