using System;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите число: ");
                var number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Сумма цифр числа {number} равна {SumDigit(number)}");
            } while (true);
        }

        static int SumDigit(int number)
        {
            var result = 0;

            while (number > 0)
            {
                result += number % 10;
                number /= 10;
            }
            
            return result;
        }
    }
}
