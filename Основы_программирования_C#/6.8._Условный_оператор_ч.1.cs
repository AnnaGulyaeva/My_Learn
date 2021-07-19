// Слон

// Задача: требуется определить, бьет ли слон, стоящий на клетке с указанными координатами (номер строки и номер столбца),
// фигуру, стоящую на другой указанной клетке.

// Входные данные: вводятся четыре числа: координаты слона и координаты другой фигуры. Координаты - целые числа в интервале от 1 до 8.

// Выходные данные: требуется вывести слово "YES", если слон способен побить фигуру за 1 ход, в противном случае вывести слово "NO".

using System;

public class MainClass
{
    public static void Main()
    {
            int x1 = Convert.ToInt16(Console.ReadLine());
            int y1 = Convert.ToInt16(Console.ReadLine());
            int x2 = Convert.ToInt16(Console.ReadLine());
            int y2 = Convert.ToInt16(Console.ReadLine());
            if (x1-y1 == x2-y2 || x1+y1 == x2+y2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
    }
}
