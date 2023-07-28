using System;

namespace Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;
            int columns = 4;
            int [,] matrix = new int [rows,columns];  
            var random = new Random();  

            for (int i= 0; i < matrix.GetLength(0); i++ )
            {
                for( int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = random.Next(0,10);
                    Console.Write(matrix[i,j]+" ");
                }

                Console.WriteLine();
            }

            Console.Write("Введите номер строки: ");
            int rowNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер столбца: ");
            int colNumber = Convert.ToInt32(Console.ReadLine());

            if (rowNumber > 0 && rowNumber <= matrix.GetLength(0) && colNumber > 0 && colNumber <= matrix.GetLength(1))
                Console.WriteLine(matrix[rowNumber - 1, colNumber - 1]);

            else
                Console.WriteLine("Такого числа в массиве нет");
        }
    }
}
