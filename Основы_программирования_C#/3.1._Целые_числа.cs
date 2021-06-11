// Три числа

// Задача: написать программу, которая находит сумму и произведение трёх целых чисел, введённых с клавиатуры.

// Формат входных данных: на вход дается три целых числа, каждое из которых не превышает по модулю 1000.

// Формат выходных данных: вывести на одной строке через пробел два целых числа - сумму и произведение исходных чисел.

using System;

public class MainClass
{
    public static void Main()
    {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int summa = a + b + c;
            int proisvedenie = a * b * c;
            Console.WriteLine(summa + " " + proisvedenie);
    }
}
