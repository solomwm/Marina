using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray2D
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
        }
    }
}
