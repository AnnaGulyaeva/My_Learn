// Стоимость покупки

// Задача: пирожок в столовой стоит a a a рублей и b b b копеек. 
// Определить, сколько рублей и копеек нужно заплатить за n n n пирожков.

// Формат входных данных: программа получает на вход три целых числа: a, b, n. a, b, n. a, b, n.

// Формат выходных данных: программа должна вывести два числа: стоимость покупки в рублях и копейках.

using System;

public class MainClass
{
    public static void Main()
    {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a * n) + (b * n / 100) + " " + (b * n % 100));
    }
}
