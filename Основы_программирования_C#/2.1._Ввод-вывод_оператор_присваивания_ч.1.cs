// Квадрат числа
// Задача: по данному целому числу, найти его квадрат.
// Формат входных данных: на вход дается одно целое число, по модулю не превосходящее 100.
// Формат выходных данных: программа должна вывести квадрат данного числа.

using System;

public class MainClass
{
    public static void Main()
    {
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);
            int b = a * a;
            Console.WriteLine(b);
    }
}
