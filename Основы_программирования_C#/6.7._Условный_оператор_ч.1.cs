// Ладья

// Задача: требуется определить, бьет ли ладья, стоящая на клетке с указанными координатами (номер строки и номер столбца),
// фигуру, стоящую на другой указанной клетке.

// Входные данные: вводятся четыре числа: координаты ладьи (два числа) и координаты другой фигуры (два числа),
// каждое число вводится в отдельной строке. Координаты - целые числа в интервале от 1 до 8.

// Выходные данные: требуется вывести слово "YES", если ладья сможет побить фигуру за 1 ход и "NO" - в противном случае.

using System;

public class MainClass
{
    public static void Main()
    {
            int x1 = Convert.ToInt16(Console.ReadLine());
            int y1 = Convert.ToInt16(Console.ReadLine());
            int x2 = Convert.ToInt16(Console.ReadLine());
            int y2 = Convert.ToInt16(Console.ReadLine());
            if (x1 == x2 || y1 == y2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
    }
}
