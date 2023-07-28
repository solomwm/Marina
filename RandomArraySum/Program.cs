using System;

namespace RandomArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var array = new int[4];
            //var random = new Random();
            //var sumOdd = 0;

            //for (var i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(-100, 100);

            //    if ((i + 1) % 2 > 0)
            //    {
            //        sumOdd += array[i];
            //    }

            //    Console.Write(array[i] + " ");
            //}

            //Console.WriteLine();
            //Console.WriteLine($"Сумма элементов на нечётных позициях: {sumOdd}");

            //int arrayLangth = 4;
            //int [] array = new int[arrayLangth];
            //int resultSum = 0;
            //Random random = new Random();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i]= random.Next(10,100 );
            //    Console.Write(array[i] + " ");

            //    if ((i+1) % 2 > 0 )
            //    {   
            //        resultSum += array[i];
            //    }
            //}

            //Console.WriteLine($"Сумма элементов на нечётных позициях: {resultSum}");

            int rows = 4;
            int columns = 4;

            double [,] matrix= new double[rows,columns];

            var random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j <  matrix.GetLength(1); j++)
                {
                    matrix[i,j] = random.NextDouble()*200 - 100; 
                    Console.Write(matrix[i,j]+ " ");
                }

                Console.WriteLine();
            }
        }
    }
}
