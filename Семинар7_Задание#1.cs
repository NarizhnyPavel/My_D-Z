using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] mas = new int[10,10];
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    mas[i, x] = i * x;
                }
            }
            int d;
            for(int i = 1; i < 10; i++)
            {
                for(int x = 1; x < 10; x++) 
                {
                    d = mas[i, x] / 10; //проверяю из скольки цифр состоит число
                    if (d >= 1) Console.Write(mas[i, x] + " ");
                    else Console.Write(mas[i, x] + "  ");
                } 
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
