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
                a = mas[i + 1];
                if (mas[i] < a) 
                    if (i == n - 2)
                        Console.WriteLine("Массив является возрастающей последовательностью");
                if (mas[i] > a) //дополнительная проверка на убывание
                    if (i == n - 2)
                        Console.WriteLine("Массив является убывающей последовательностью");
                else if (i == 1)
                {
                    Console.WriteLine("Массив не является убывающей или возрастающей последовательностью");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
