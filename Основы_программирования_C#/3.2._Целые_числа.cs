// Дележ яблок - 1

// Задача: N N N школьников делят K K K яблок поровну, неделящийся остаток остается в корзинке.
// Сколько яблок достанется каждому школьнику?

// Формат входных данных: на вход дается два целых положительных числа N N N и K K K, каждое из которых не превышает 10000 10000 10000.

// Формат выходных данных: программа должна вывести искомое количество яблок.

using System;

public class MainClass
{
    public static void Main()
    {
            int N = Convert.ToInt32(Console.ReadLine());
            int K = Convert.ToInt32(Console.ReadLine());
            int Isk = K / N;
            Console.WriteLine(Isk);
    }
}
