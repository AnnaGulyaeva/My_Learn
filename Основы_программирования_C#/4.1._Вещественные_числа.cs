// Среднее арифметическое

// Задача: даны два числа. Найти их среднее арифметическое.

// Формат входных данных: на вход дается два целых положительных числа a и b, каждое из которых не превышает 10000.

// Формат выходных данных: программа должна вывести среднее арифметическое чисел a и b.

using System;

public class MainClass
{
    public static void Main()
    {
            int а = Convert.ToInt32(Console.ReadLine());
            int б = Convert.ToInt32(Console.ReadLine());
            double с = (double)(а + б) / 2;
            Console.WriteLine(с);
    }
}
