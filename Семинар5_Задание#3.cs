using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел для сложения:");
            int n = Convert.ToInt32(Console.ReadLine());
            int summ = 0;
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Число" + " " + i + ":");
                a = Convert.ToInt32(Console.ReadLine());
                summ = summ + a;
            }
            Console.WriteLine("Сумма чисел= " + summ);
            Console.ReadLine();
        }
    }
}
