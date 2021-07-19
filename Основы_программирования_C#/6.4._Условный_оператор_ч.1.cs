// Делимость

// Задача: проверить делится ли a на b нацело.

// Формат входных данных: на вход подаются два целых числа a и b, каждое из которых по модулю не превышает 10^6. 
// Гарантируется что b не равно нулю. 

// Формат выходных данных: вывести "YES", если a делится на b нацело, в противном случае - "NO".

using System;

public class MainClass
{
    public static void Main()
    {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
    }
}
