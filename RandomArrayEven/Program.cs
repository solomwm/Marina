using System;

namespace RandomArrayEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[4];
            var random = new Random();
            var evenCount = 0;

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 999);

                if (array[i] % 2 == 0)
                {
                    evenCount++;
                }

                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
        }
    }
}
