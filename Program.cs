using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int row;
            int col;
            char op = '~';
            float sum = 13;

            Console.WriteLine("Enter the size of the matrix.");
            Console.Write("rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("columns: ");
            int cols = int.Parse(Console.ReadLine());
            float[,] matrix = new float[rows, cols];

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToSingle(random.NextDouble());
                }
            }

            while(true)
            {
                Console.WriteLine("Enter the row of the number you want to use: ");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the col of the number you want to use: ");
                col = int.Parse(Console.ReadLine());
                if(row < 0 || row >= rows || col < 0 || col >= cols)
                {
                    Console.WriteLine("Invalid index!");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Enter the second number you want to use: ");
            float num2 = float.Parse(Console.ReadLine());

            bool temp = true;
            while (temp == true)
            {
                Console.WriteLine("Enter the operator you want to use: ");
                op = char.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case '+':
                        {
                            sum = matrix[row, col] + num2;
                            temp = false;
                            break;
                        }
                    case '-':
                        {
                            sum = matrix[row, col] - num2;
                            temp = false;
                            break;
                        }
                    case '*':
                        {
                            sum = matrix[row, col] * num2;
                            temp = false;
                            break;
                        }
                    case '/':
                        {
                            sum = matrix[row, col] / num2;
                            temp = false;
                            break;
                        }
                    case '%':
                        {
                            sum = matrix[row, col] % num2;
                            temp = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid operator!");
                        break;

                }
            }
            

            Console.Write(matrix[row, col]);
            Console.Write(" ");
            Console.Write(op);
            Console.Write(" ");
            Console.Write(num2);
            Console.Write(" = ");
            Console.WriteLine(sum);
        }
    }
}
