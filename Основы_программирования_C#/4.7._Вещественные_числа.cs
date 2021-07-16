// Первая цифра после точки

// Задача: дано положительное действительное число x x x. Вывести его первую цифру после десятичной точки.

// Входные данные: вводится положительное действительное число, не превосходящее 10000 10000 10000.

// Выходные данные: вывести ответ на задачу.

using System;

public class MainClass
{
    public static void Main()
    {
            double x = Convert.ToDouble(Console.ReadLine());
            double a = x * 10;
            int b = (int)a;
            Console.WriteLine(b % 10);
    }
}
