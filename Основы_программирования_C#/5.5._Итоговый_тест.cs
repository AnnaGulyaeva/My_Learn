// Дележ яблок - 3

// Задача n школьников делят k яблок "поровну”, то есть так, чтобы количество яблок, доставшихся любым двум школьникам, отличалось бы не более, чем на 1.

// Входные данные: программа получает на вход числа n (n>0) и k, каждое из которых не превышает 10000.

// Выходные данные: программа должна вывести количество школьников, которым достанется яблок меньше, чем некоторым из их товарищей.

using System;

public class MainClass
{
    public static void Main()
    {
int n = Convert.ToInt32(Console.ReadLine());
int k = Convert.ToInt32(Console.ReadLine());
int a = k / n * n; //количество яблок, которые разойдутся школьникам без остатка
int b = k - a; // количество оставшихся яблок
int c = n - b; // количество школьников, которые не получили оставшиеся яблоки
Console.WriteLine(c % n); // проверка на случай если все получат одинаковое количество яблок
    }
}
