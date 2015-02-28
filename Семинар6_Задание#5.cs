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
            Console.WriteLine("Начало битвы Бэтмен VS Черепашка-ниндзя");
            Console.WriteLine("Правила: противники по очереди наносят друг другу удары."); 
            Console.WriteLine("Наносить удары можно по: голове, телу  и ногам.");
            Console.WriteLine("БЭТМЕН: уязвимость головы: 3 удара, тела: 4 удара, ног: 3 удара.");
            Console.WriteLine("ЧЕРЕПАШКА: уязвимость головы: 2 удара, тела: 3 удара, ног: 4 удара.");
            Console.WriteLine("У каждого по 5 жизней");
            int i = 1;
            string part;
            batman h1 = new batman();
            tortoise h2 = new tortoise();
            h1.lifes = 5;
            h2.lifes = 5;
            while(true)
            {
                if (i == 1) Console.WriteLine(i + " бой:");
                Console.Write(i + " ход ");
                if (i % 2 == 0)
                {
                    Console.WriteLine("бэтмена:");
                    Console.Write("Куда бить? ");
                    part = Console.ReadLine();
                    if (part == "голова") h2.head++;
                    if (part == "тело") h2.body++;
                    if (part == "ноги") h2.legs++;
                    i++;
                }
                else
                {
                    Console.WriteLine("черепашки:");
                    Console.Write("Куда бить? ");
                    part = Console.ReadLine();
                    if (part == "голова")
                    {
                        h1.head++;
                        Console.WriteLine("Урон на голову:" + h1.head);
                    }
                    if (part == "тело")
                    {
                        h1.body++;
                        Console.WriteLine("Урон на тело:" + h1.body);
                    }
                    if (part == "ноги")
                    {
                        h1.legs++;
                        Console.WriteLine("Урон на ноги:" + h1.legs);
                    }
                    i++;
                }
                if (h1.head == 3) h1.lifes--;
                if (h1.body == 4) h1.lifes--;
                if (h1.legs == 3) h1.lifes--;
                if (h1.head == 2) h1.lifes--;
                if (h1.body == 3) h1.lifes--;
                if (h1.legs == 4) h1.lifes--;
                if (h1.lifes == 0)
                {
                    Console.WriteLine("Бэтмен проиграл. Выйграла черепашка!");
                    break;
                }
                if (h2.lifes == 0)
                {
                    Console.WriteLine("Черепашка проиграла. Выйграл бэтмен!");
                }
                if (i == 3)
                {
                    Console.WriteLine("Окончен " + (i-2) + " бой");
                    Console.WriteLine("У бэтмена " + h1.lifes + " жизней.");
                    Console.WriteLine("У черепашки " + h2.lifes + " жизней.");
                    i = 1;
                }
            }
        }
    }
}
