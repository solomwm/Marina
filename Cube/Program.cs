using System;
using System.Collections.Generic;

namespace Cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите число: ");
                var number = Convert.ToInt32(Console.ReadLine());
                var cubeList = new List<string>(number);

                for (int i = 1; i <= number; i++)
                {
                    var s = ((int)Math.Pow(i, 3)).ToString();
                    cubeList.Add(s);
                }

                Console.WriteLine($"Кубы чисел от 1 до {number} -> ({string.Join(", ", cubeList)})");

            } while (true);
        }
    }
}
