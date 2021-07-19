// Знак числа

// Формат входных данных: на вход подается одно целое число x, по модулю не превышающее 10000.

// Формат выходных данных: для данного числа x выведите значение sign(x).

using System;

public class MainClass
{
    public static void Main()
    {
            int x = Convert.ToInt32(Console.ReadLine());
            int signx = 0;
            if (x < 0)
            {
                Console.WriteLine(signx = -1);
            }
            else
            {
                if (x == 0)
                {
                    Console.WriteLine(signx = 0);
                }
                else
                {
                    Console.WriteLine(signx = 1);
                }
            }
    }
}
