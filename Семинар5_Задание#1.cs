using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Семинар5_Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.Write(Math.Pow(i, 2) + " ");
            }
            Console.ReadLine();
        }
    }
}
