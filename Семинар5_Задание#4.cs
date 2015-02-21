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
            Console.WriteLine("Привет! Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine(name + ", будем тренировать устный счет!");
            int otv;
            int ball = 0;
            Random c = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int a = c.Next(20);
                int b = c.Next(20);
                Console.WriteLine("Перемножь " + a + " и " + b);
                otv = Convert.ToInt32(Console.ReadLine());
                if (otv == a * b)
                {
                    if (i != 10)
                    {
                        Console.WriteLine("Ответ правильный! " + name + ", ты набрал 1 балл. Следующий пример:");
                    }
                    else 
                    {
                        Console.WriteLine("Ответ правильный! " + name + ", ты набрал 1 балл.");
                    }
                    ball++;
                }
                else
                {
                    if (i != 10)
                    {
                        Console.WriteLine("Ответ не правильный. Следующий пример:");
                    }
                    else
                    {
                        Console.WriteLine("Ответ не правильный.");
                    }
                }
                
            }
            if (ball > 0)
            {
                Console.WriteLine("Мои поздравления, ты набрал " + ball + " балл(ов) из 10. Хорошо потренировались)");
            }
            else
            {
                Console.WriteLine("Ты не набрал ни одного балла. Это плохо. Повторяй таблицу умножения!");
            }
            Console.ReadLine();
        }
    }
}
