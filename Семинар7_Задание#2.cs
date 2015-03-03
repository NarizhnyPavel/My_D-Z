using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a;
            int[,] mas = new int[5, 5];
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    a = rand.Next(5);
                    mas[x, y] = a;
                }
            }
            //вывод матрицы
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++) Console.Write(mas[x, y] + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
            //замена диагоналей
            int c;
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if ((x == 0) || (x == 4))
                    {
                        if (y == 0)
                        {
                            c = mas[x, y];
                            mas[x, y] = mas[x, y + 4];
                            mas[x, y + 4] = c;
                        }
                    }
                    if ((x == 1) || (x == 3))
                    {
                        if (y == 1) 
                        {
                            c = mas[x, y];
                            mas[x, y] = mas[x, y + 2];
                            mas[x, y + 2] = c;
                        }
                    }
                }
            }
            //вывод матрицы
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++) Console.Write(mas[x, y] + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
