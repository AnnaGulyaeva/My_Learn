// Максимум из двух чисел

// Задача: вывести максимальное из двух чисел. Если числа равны, вывести любое из них.

// Формат входных данных: даны два целых числа, каждое из которых не превышает 100000.

// Формат выходных данных: вывести максимальное из них.

using System;

public class MainClass
{
    public static void Main()
    {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
    }
}
