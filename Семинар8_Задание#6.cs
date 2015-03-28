class Program
    {
        static void Main(string[] args)
        {
            string password = pasword();
            Console.WriteLine(password);
            Console.ReadLine();
        }
        static string pasword()
        {
            Random rand = new Random();
            int[] mas = new int[4];
            mas[0] = rand.Next(97, 122);
            mas[1] = rand.Next(0,9);
            mas[2] = rand.Next(97, 122);
            mas[3] = rand.Next(0,9);
            
            Char b;
            string password = "";
            for (int i = 0; i < 4; i++)
            {
                int z = rand.Next(4);
                if (i > 0)
                    for (int x = 0; x < password.Length; x++)
                        if (mas[z] == password[x])
                        {
                            z = rand.Next(4);
                            x = 0;
                        }
                if (mas[z] > 96)
                {
                    b = (char)mas[z];
                    password = password + b;
                }
                else password = password + mas[z];
            }
            return password;
        }
    }
