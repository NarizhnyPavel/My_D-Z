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
            int[,] mas = new int[3,4];//не догадался как заранее объявить переменные
            string[] n = new string[3]{"Иванов", "Петров", "Сидоров"};
            string[] m = new string[4]{"январь", "февраль", "март", "апрель"};
            int[] name_symm = new int[3];
            int[] month_symm = new int[4];
            //заполнение значений трафика (mas)
            for (int i = 0; i < 3; i++)
                for (int y = 0; y < 4; y++)
                {
                    Console.Write("Введите трафик " + n[i] + "а за " + m[y] + ": ");
                    mas[i, y] = Convert.ToInt32(Console.ReadLine());
                }
            //вычисление всего кол-ва трафика по фамилии и месяцу
            for (int i = 0; i < 3; i++)
                for(int y = 0; y < 4; y++)
                {
                    name_symm[i] = name_symm[i] + mas[i, y];
                    if (y < 3) month_symm[i] = month_symm[i] + mas[y, i];
                    if (y < 3)
                        if (i == 2)
                        {
                            i++;
                            month_symm[i] = month_symm[i] + mas[y, i];
                            i--;
                        }
                }
            //вывод значений 
            for(int i = 0; i<3; i++) Console.WriteLine(n[i] + " за данный период(янв-апр) израсходовал: " + name_symm[i]);
            for (int i = 0; i < 4; i++) Console.WriteLine("За " + m[i] + " было израсходовано: " + month_symm[i]);
            Console.ReadLine();
        }
    }
}
