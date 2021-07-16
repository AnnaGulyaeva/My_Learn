// Объем информации

// Формат входных данных: на вход подается одно целое число - количество бит.

// Формат выходных данных: переведите данное количество информации в килобайты.

// Примечание: ответ может быть вещественным числом.

using System;

public class MainClass
{
    public static void Main()
    {
            int B = Convert.ToInt32(Console.ReadLine());
            double KB = B / Math.Pow(2, 13);
            Console.WriteLine(KB);
    }
}
