using System;
using System.Windows.Forms;
namespace Project1
{
    public class Project1Unit
    {
        public static string grid = String.Empty;
        public static string commands = String.Empty;
        public static string direcao = String.Empty;
        public static int m = 0;
        public static int n = 0;
        public static int i = 0;
        public static int x = 0;
        public static int y = 0;
        public static void AlteraDirecao(string comando)
        {
            if (comando.Equals("L"))
            {
                if (direcao.Equals("North"))
                {
                    direcao = "West";
                }
                if (direcao.Equals("West"))
                {
                    direcao = "South";
                }
                if (direcao.Equals("South"))
                {
                    direcao = "East";
                }
                if (direcao.Equals("East"))
                {
                    direcao = "North";
                }
            }
            else if (comando.Equals("R"))
            {
                if (direcao.Equals("North"))
                {
                    direcao = "East";
                }
                else if (direcao.Equals("East"))
                {
                    direcao = "South";
                }
                else if (direcao.Equals("South"))
                {
                    direcao = "West";
                }
                else if (direcao.Equals("West"))
                {
                    direcao = "North";
                }
            }
        }

        public static void AlteraPosicao(string direcao)
        {
            if (direcao.Equals("North"))
            {
                if (x > 1)
                {
                    x = x - 1;
                }
            }
            if (direcao.Equals("South"))
            {
                if (x < m)
                {
                    x = x + 1;
                }
            }
            if (direcao.Equals("East"))
            {
                if (y < n)
                {
                    y = y + 1;
                }
            }
            if (direcao.Equals("West"))
            {
                if (y > 1)
                {
                    y = y - 1;
                }
            }
        }

        [STAThread]
        public static void Main(string[] args)
        {
   //         Console.WriteLine("teste");
            string[] grid = Console.In.ReadLine().Split('x');
            //@ Undeclared identifier(3): 'StrToInt'
            m = int.Parse(grid[0]);
            //@ Undeclared identifier(3): 'StrToInt'
            n = int.Parse(grid[1]);
            x = 1;
            y = 1;
            direcao = "North";
            //       Console.Out.WriteLine("digite os comandos");
            commands = Console.In.ReadLine();
            for (i = 0; i < commands.Length; i++)
            {
                AlteraDirecao(char.ToString(commands[i]));
                if (commands[i].Equals('F'))
                {
                    AlteraPosicao(direcao);
                }
            }
            Console.Out.Write(x);
            Console.Out.Write(',');
            Console.Out.Write(y);
            Console.Out.Write(',');
            Console.Out.Write(direcao);
            Console.In.ReadLine();

            //  Application.Run();
        }

    } // end Project1

}

