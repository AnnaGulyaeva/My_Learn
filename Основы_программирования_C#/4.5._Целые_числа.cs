// Расстояние между точками

// Задача: найти расстояние между двумя точками с заданными координатами (x1,y1) и (x2,y2).

// Формат входных данных: на вход подаются 4 4 4 целых числа x1,y1,x2,y2 - координаты двух точек.

// Формат выходных данных: программа должна вывести расстояние между этими точками.

using System;

public class MainClass
{
    public static void Main()
    {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y2 - y1);
            double S= Math.Sqrt((Math.Pow(a,2)) + Math.Pow(b,2));
            Console.WriteLine(S);
    }
}
