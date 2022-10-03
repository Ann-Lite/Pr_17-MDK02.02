using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_17_MDK02._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения ");
            if (int.TryParse(Console.ReadLine(), out int M) == false) Console.WriteLine("Введенное значение не верно ");
            Console.WriteLine("Введите значения ");
            if(int.TryParse(Console.ReadLine(), out int N) == false) Console.WriteLine("Введенное значение не верно ");
            int[,] Matr = new int[M, N];
            Random rand = new Random();
            int posX = 0;
            int posY = 0;
            
            for (int i= 0; i<M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Matr[i, j] = rand.Next(-10, 10);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0 ; j < N; j++)
                {
                    Console.Write("{0,2}", Matr[i, j]);
                }
                Console.WriteLine();
            }

            for (int j = 0; j < N; j++)
            {
                for(int i = 0; i < M; i++)
                {
                    if (Matr[i, j] == 0)
                    {
                        posX = i;
                        posY = j;
                        Console.WriteLine($"Строка - {posX+1}, столбец{posY+1}");
                        Console.ReadKey();
                    }
                }
            }

            Console.WriteLine($"Нулевых значений в массиве нет");
            Console.ReadKey();
        }
    }
}
