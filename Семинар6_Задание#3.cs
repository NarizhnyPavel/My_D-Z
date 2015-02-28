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
            Console.WriteLine("таблица значений для 1-ой функции");
            Console.Write("x|");
            for (int x = 0; x <= 4; x++) Console.Write(x + "|");
            Console.WriteLine();
            Console.Write("y|");
            for (int y = 0; y <= 4; y++) Console.Write((2 * y + 1) + "|");
            Console.WriteLine();

            Console.WriteLine("Таблица значений для 2-ой функции");
            Console.Write("x|");
            for (int x = 0; x <= 4; x++) Console.Write(x + "|");
            Console.WriteLine();
            Console.Write("y|");
            for (int y = 0; y <= 4; y++) Console.Write((Math.Pow(y,2)) + "|");
            Console.WriteLine();
            Console.ReadLine();
        } 
    }
}
