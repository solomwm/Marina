using System;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int number;
                bool isCorrect;

                do
                {
                    Console.WriteLine("Введите пятизначное число: ");
                    var res = int.TryParse(Console.ReadLine(), out number);
                    isCorrect = res && number >= 10000 && number <= 99999;
                } while (!isCorrect);

                Console.WriteLine(IsPalindrom(number) ? "Это палиндром" : "Это не палиндром");

            } while (true);
        }

        static bool IsPalindrom(int number)
        {
            var sourceNumber = number;
            var reverseNumber = number % 10;

            while (sourceNumber / 10 > 0)
            {
                sourceNumber /= 10;
                reverseNumber = reverseNumber * 10 + sourceNumber % 10;
            }

            return number == reverseNumber;
        }
    }
}
