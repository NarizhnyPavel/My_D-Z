using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во чисел: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите " + (i+1) + "-ый член массива: ");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int a;
            for (int i = 0; i < n - 1; i++)
            {
                for (int x = i + 1; x < n; x++)
                    if (mas[i] < mas[x])
                    {
                        a = mas[i];
                        mas[i] = mas[x];
                        mas[x] = a;
                    }
            }
            Console.Write("Отсортированный по убыванию масиив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
