using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0, sum5 = 0;
            Random random = new Random();
            int m = 5;
            int[,] A = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = random.Next(0,100);
                    Console.Write(A[i, j] + "   ");
                }
                Console.WriteLine();
                if (A[0, 0]%2 == 0)
                {
                    sum1 = A[0,0] + A[0, 1] + A[0, 2] + A[0, 3] + A[0, 4];
                }
                if (A[1, 1] % 2 == 0)
                {
                    sum2 = A[1, 0] + A[1, 1] + A[1, 2] + A[1, 3] + A[1, 4];
                }
                if (A[2, 2] % 2 == 0)
                {
                    sum3 = A[2, 0] + A[2, 1] + A[2, 2] + A[2, 3] + A[2, 4];
                }
                if (A[3, 3] % 2 == 0)
                {
                    sum4 = A[3, 0] + A[3, 1] + A[3, 2] + A[3, 3] + A[3, 4];
                }
                if (A[4, 4] % 2 == 0)
                {
                    sum5 = A[4, 0] + A[4, 1] + A[4, 2] + A[4, 3] + A[4, 4];
                }
            }
            if (sum1 != 0)
                Console.WriteLine("Сумма первой строки = " + sum1);
            if (sum2 != 0)
                Console.WriteLine("Сумма втрой строки = " + sum2);
            if (sum3 != 0)
                Console.WriteLine("Сумма третьей строки = " + sum3);
            if (sum4 != 0)
                Console.WriteLine("Сумма четвертой строки = " + sum4);
            if (sum5 != 0)
                Console.WriteLine("Сумма пятой строки = " + sum5);
            Console.ReadLine();
        }
    }
}
