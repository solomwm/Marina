using System;

namespace Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("x1 = ");
                var x1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("y1 = ");
                var y1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("z1 = ");
                var z1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("x2 = ");
                var x2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("y2 = ");
                var y2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("z2 = ");
                var z2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Расстояние = " + Distance(x1, y1, z1, x2, y2, z2));

            } while (true);
        }

        static double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        }
    }
}
