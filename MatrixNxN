using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixNxN
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumD = 0;
            int sumM = 0;
            var random = new Random();
            Console.WriteLine("Enter the size of the matrix: ");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    matrix[i , j] = random.Next() % 100;
                }
            }

            for (int i = 0; i < size; i++)
            {
                sumD += matrix[i, i];
            }

            int temp = size - 1;
            for (int i = 0; i < size; i++)
            {
                if(i != temp)
                {
                    sumD += matrix[i, temp];
                }
                temp--;
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sumM += matrix[i, j];
                }
            }

            Console.Write("The sum of the diagonals is: ");
            Console.WriteLine(sumD);
            Console.Write("The sum of the whole matrix is: ");
            Console.WriteLine(sumM);

        }
    }
}
