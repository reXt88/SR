using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //заполнение массива случайными числами
            Random random = new Random();
            int m = 5;
            int[,] A = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = random.Next(10, 100);
                    Console.Write(A[i, j] + "   ");
                }
                Console.WriteLine();
            }
            //алгоритм сортировки
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[1, 1] > A[0, 0])
                    {
                        int temp;
                        temp = A[1, 1];
                        A[1, 1] = A[0, 0];
                        A[0, 0] = temp;
                    }
                    if (A[2, 2] > A[1, 1])
                    {
                        int temp;
                        temp = A[2, 2];
                        A[2, 2] = A[1, 1];
                        A[1, 1] = temp;
                    }
                    if (A[3, 3] > A[2, 2])
                    {
                        int temp;
                        temp = A[3, 3];
                        A[3, 3] = A[2, 2];
                        A[2, 2] = temp;
                    }
                    if (A[4, 4] > A[3, 3])
                    {
                        int temp;
                        temp = A[4, 4];
                        A[4, 4] = A[3, 3];
                        A[3, 3] = temp;
                    }
                }
            }
            //вывод отсортированного массива
            Console.WriteLine("Исправленный массив");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
