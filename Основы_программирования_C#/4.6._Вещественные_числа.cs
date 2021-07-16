// Дробная часть

// Задача: дано положительное действительное число x. Вывести его дробную часть.

// Входные данные: вводится положительное действительное число.

// Выходные данные: вывести ответ на задачу.

using System;

public class MainClass
{
    public static void Main()
    {
            double x = Convert.ToDouble(Console.ReadLine());
            int c = (int)x;
            Console.WriteLine(x - c);
    }
}
