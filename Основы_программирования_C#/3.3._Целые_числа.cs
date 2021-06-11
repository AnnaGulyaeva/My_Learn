// Работа с переменными

// Задача: дано число x x x. Вычислить число x6 x^6 x6 при помощи трех операций умножения.

// Формат входных данных: программа получает на вход одно число x x x.

// Формат выходных данных: программа должна вывести x6 x^6 x6 при помощи трех операций.

using System;

public class MainClass
{
    public static void Main()
    {
            int x = Convert.ToInt32(Console.ReadLine());
            int a = x * x;
            Console.WriteLine(a * a * a);
    }
}
