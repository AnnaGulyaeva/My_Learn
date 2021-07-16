// Периметр прямоугольного треугольника

// Задача: найти периметр прямоугольного треугольника с заданными катетами. 

// Формат входных данных: на вход подаются два положительных  вещественных числа - длины катетов прямоугольного треугольника.

// Формат выходных данных: программа должна вывести периметр заданного прямоугольного треугольника.

// Примечание: не нужно программно округлять число до сотых. 

using System;

public class MainClass
{
    public static void Main()
    {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            Console.WriteLine(a+b+c);
    }
}
