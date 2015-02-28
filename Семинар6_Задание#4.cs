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
            Console.WriteLine("  Пн Вт Ср Чт Пт");
            for (int i = 1; i <= 6; i++)
            {
                Console.Write(i + " ");
                for (int x = 1; x <= 5; x++) Console.Write("__ ");
                Console.WriteLine();
            }
            Console.ReadLine();
        } 
    }
}
