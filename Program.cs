using System;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нахождение среднего арифметического двух чисел");
            Console.WriteLine("Введите два числа через enter");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            float c = ((float)a + b) / 2;
            Console.WriteLine($"Среднеее арифметическое чисел {a} и {b} равно {c}");
        }
    }
}
