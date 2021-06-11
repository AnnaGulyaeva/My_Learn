// Последняя цифра

// Задача: дано натуральное число, вывести его последнюю цифру.

// Формат входных данных: на вход дается натуральное число N N N, не превосходящее 10000 10000 10000.

// Формат выходных данных: вывести последнюю цифру числа NNN.

using System;

public class MainClass
{
    public static void Main()
    {
            double N = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(N % 10);
    }
}
