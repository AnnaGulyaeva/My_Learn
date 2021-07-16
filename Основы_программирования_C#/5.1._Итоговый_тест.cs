// Гипотенуза

// Задача: найти гипотенузу треугольника с заданными катетами.

// Входные данные: на вход подаются два целых числа - длины катетов треугольника, не превышающие 1000.

// Выходные данные: вывести длину гипотенузы треугольника.

// Примечание: ответ будет считаться корректным, если его абсолютная погрешность не превосходит 10^{-3}.

using System;

public class MainClass
{
    public static void Main()
    {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(c);
    }
}
