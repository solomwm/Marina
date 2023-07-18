using System;

namespace RandomArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[8];
            var rnd = new Random();

            do
            {
                Console.Write("[");

                for (var i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1000);
                    Console.Write(array[i] + $"{(i < array.Length - 1 ? ", " : string.Empty)}");
                }
            
                Console.WriteLine("]");
            } while (Console.ReadLine() == "q");
        }
    }
}
