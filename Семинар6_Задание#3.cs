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
          int[] y1 = new int[5];
          int[] y2 = new int[5];
          for (int i = 0; i <= 4; i++)
          { 
             y1[i]==2 * i +2;
             y2[i]==Math.Pow(i,2);
          }
          Console.WriteLine("таблица значений для 1-ой функции");
          Console.Write("x");
          for(int x = 0;x <= 4; x++) Console.Write(x + "|");
          Console.WriteLine("|");
          Console.WriteLine("y");
          for(int y = 0; y <=4; y++) Console.Write((2 * y + 2) + "|");
          Console.WriteLine("|");
          
          
