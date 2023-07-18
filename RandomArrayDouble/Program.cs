using System;

namespace RandomArrayDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new double[4];
            var random = new Random();

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * 100;
                Console.Write(Math.Round(array[i], 2) + " ");
            }

            var min = array[0];
            var max = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {Math.Round(max - min, 2)}");
        }
    }
}
