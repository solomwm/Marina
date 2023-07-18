using System;

namespace RandomArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[4];
            var random = new Random();
            var sumOdd = 0;

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);

                if ((i + 1) % 2 > 0)
                {
                    sumOdd += array[i];
                }

                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма элементов на нечётных позициях: {sumOdd}");
        }
    }
}
