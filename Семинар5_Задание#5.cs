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
            Random a = new Random();
            int b = a.Next(10);
            Console.WriteLine("Итак, я загадал число в диапазоне от 1 до 10. Попробуй угадать его с 5 попыток");
            int c;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Попытка № " + i + ":");
                c = Convert.ToInt32(Console.ReadLine());
                if (b == c)
                {
                    Console.WriteLine("Ты отгодал с " + i + " попытки. Молодец!");
                    Console.ReadLine();
                    i = 6;
                }
                else
                {
                    if (c > b)
                    {
                        Console.WriteLine("Число меньше");
                    }
                    if (c < b)
                    {
                        Console.WriteLine("Число больше");
                    }
                }
            }
        }
    }
}
