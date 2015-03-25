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
            mas[1] = rand.Next(1,9);
            mas[2] = rand.Next(97, 122);
            mas[3] = rand.Next(1,9);
            
            Char b;
            Char[] mass = new Char[4];
            string password = "";
            for(int i = 0; i < 4; i++)
            {
                int z = rand.Next(4);
                {
                    if (mas[z] > 96)
                    {
                        b = (char)mas[z];
                        password = password + b;
                    }
                    else password = password + mas[z];
                }
            }
            for(int z = 0; z < 4; z++)
            {
                password = password + " " + mass[z];
            }
            return password;
        }
