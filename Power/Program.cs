using System;

namespace Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите число А: ");
                var a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите показатель степени В: ");
                var b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Число {a} в степени {b} = {Math.Pow(a, b)}");
            } while (true);
        }
    }
}
