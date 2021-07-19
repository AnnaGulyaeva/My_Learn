// Четное число

// Задача: по данному числу, проверить является ли число четным.

// Формат входных данных: на вход подается одно целое число, по модулю не превышающее 10^7. 

// Формат выходных данных: вывести "YES" если число четное, в противном случае - "NO".

using System;

public class MainClass
{
    public static void Main()
    {
            int a = Convert.ToInt32(Console.ReadLine());
            int x = a % 2;
            if (x==0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
    }
}
