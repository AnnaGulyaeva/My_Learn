// Площадь круга

// Задача: найти площадь круга заданного радиуса R.
// В качестве значения числа π использовать 3.14.

// Формат входных данных: на вход подается положительное вещественное число R - радиус круга, не превышающее 1000. 

// Формат выходных данных: программа должна вывести площадь круга радиуса R.

// Решение 1:

using System;

public class MainClass
{
    public static void Main()
    {
            double R = Convert.ToDouble(Console.ReadLine());
            double p = 3.14;
            Console.WriteLine((Math.Pow(R, 2)) * p);
    }
}

// Решение 2:

using System;

public class MainClass
{
    public static void Main()
    {
            double R = Convert.ToDouble(Console.ReadLine());
            double p = 3.14;
            double S = (Math.Pow(R, 2)) * p;
            Console.WriteLine(S);
    }
}
