// Цифры числа

// Задача: по данному трехзначному числу, определить все ли его цифры различны.

// Формат входных данных: на вход подается одно натуральное трехзначное число.

// Формат выходных данных: вывести "YES", если все цифры числа различны, в противном случае - "NO".

using System;

public class MainClass
{
    public static void Main()
    {
            int a = Math.Abs(Convert.ToInt16(Console.ReadLine()));
            int x = a / 100;
            int y = a % 100 / 10;
            int z = a % 10;
            if (!(x == y) && !(y == z) && !(x == z))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
    }
}
