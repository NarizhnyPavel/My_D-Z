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
            int N = 1;
            for (int i = 1; i <= 20; i++)
            {
                String repeatedString = new String('*', N);
                Console.WriteLine(repeatedString);
                N++;
            }
            Console.ReadLine();
        }
    }
}
