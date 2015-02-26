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
            string true_password = "admin";
            string password;
            while (true)
            {
                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();
                if (password == true_password)
                {
                    Console.WriteLine("Добро пожаловать, Админ!");
                    Console.ReadLine();
                    break;
                }
                if (password == "exit") break;
            }
        }
    }
}
