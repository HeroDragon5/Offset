using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Offset
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matr = new int[7, 7] { { 21, 35, 64, 32, 24, 53, 32 }, { 54, -3, 12, -4, 43, 12, -3 }, { 65, -3, 45, -5, 32, 15, -3 }, { 32, -4, 53, 23, -1, 55, 96 }, { 84, 72, 12, 75, -3, -1, -3 }, { 56, -7, -2, -4, 53, 34, 12 }, { -4, -2, 32, 12, 73, 54, -2 } };
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                    Console.Write(matr[i, j] + " ");
                Console.WriteLine();
            }
            int min = matr[0, 0];
            for (int i = 0; i < 7; i++)
            {
                for (int j = i; j < 7; j++)
                {
                    if (min > matr[i, j]) { min = matr[i, j]; }
                }
            }
            Console.WriteLine("Минимальный элемент, лежащий выше главной диагонали: " + min);
            Console.ReadKey();
        }
    }
}
