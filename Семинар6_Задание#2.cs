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
            for (int i = 8; i >= 1; i--)
            {
                Console.Write(i);
                for (int z = 1; z <= 8; z++)
                {
                    if (i % 2 == 0)
                    {
                        if (z % 2 == 0) Console.Write("■");
                        if (z % 2 != 0) Console.Write("☐");// не хочет распознавать символ
                    }
                    else
                    {
                        if (z % 2 == 0) Console.Write("☐");
                        if (z % 2 != 0) Console.Write("■");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ABCDEFGH");
            //очень долго думал, но не догадался как с помощью цикла вывести буквы
            Console.ReadLine();
        }
    }
}
