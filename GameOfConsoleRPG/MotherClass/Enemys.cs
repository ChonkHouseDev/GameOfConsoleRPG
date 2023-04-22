using GameOfConsoleRPG.SonClass.enemy;
using GameOfConsoleRPG.SonClass.hero;
using GameOfConsoleRPG.SonClass.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameOfConsoleRPG.MotherClass
{
    public class Enemys
    {
        public string Name;
        public int Hp;
        public int Mana;
        public string Atk1;
        public string Atk2;
        public int Lvl;
        public int x;
        public int y;
        public int velocx;
        public int velocy;

        static bool terminado;
        static Random generador;

        static int numpeon;

        public Enemys(string name, int hp, int mana, string atk1, string atk2, int lvl, int x, int y, int velocx, int velocy) 
        {       
                Name = name;
                Hp = hp;
                Mana = mana;
                Atk1 = atk1;
                Atk2 = atk2;
                Lvl = lvl;
        }

        public EnemyPeon[] GeneradorDeEnemigos(EnemyPeon[] peon)
        {

            terminado = false;
            generador = new Random();

            numpeon = peon.Length - 1;

            //peon[numpeon].velocx = 1;
            for (int i = 0; i < peon.Length; i++)
            {
                if (numpeon >= 0)
                    peon[i].x = generador.Next(10, 50);
                peon[i].y = i * 5 + 3;
                peon[i].Color = peon[numpeon].Color;
                peon[i].Simbolo = peon[numpeon].Simbolo;
                peon[i].velocx = 1;

            }


            return peon;


        }

        public void AnimarElementos(EnemyPeon[] peon)
        {
            for (int i = 0; i < peon.Length; i++)
            {
                peon[i].x += peon[i].velocx;
                if ((peon[i].x > 60) || (peon[i].x < 10))
                    peon[i].velocx = -peon[i].velocx;
            }
        }

        public bool ComprobarEstadoDelJuegoEnemigos(EnemyPeon[] peon, Mage merlin)
        {
            for (int i = 0; i < peon.Length; i++)
            {
                if ((merlin.X == peon[i].x) && (merlin.Y == peon[i].y))
                {
                    terminado = true;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                                                          Has Muerto                                                         ");
                    Console.WriteLine("                                                           ████████                                                          ");
                    Console.WriteLine("                                          ▒▒▒▒          ████████████▓▓                                                       ");
                    Console.WriteLine("                                      ▒▒▒▒▒▒▒▒        ████████████████▓▓      ▒▒▒▒                                           ");
                    Console.WriteLine("                                   ▒▒    ▒▒▒▒      ▓▓████████████▓▓████▓▓    ▒▒▒▒▒▒▒▒                                        ");
                    Console.WriteLine("                               ░░░░    ░░▒▒▒▒    ▓▓██████████▓▓▓▓▓▓▓▓▓▓██▓▓  ▒▒▒▒    ░░                                      ");
                    Console.WriteLine("                              ▒▒▒▒    ░░░░▒▒▒▒    ████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██  ▒▒▒▒░░  ▓▓▒▒▒▒      ████████████               ");
                    Console.WriteLine("                              ▒▒▒▒    ░░░░▒▒▒▒  ██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████▒▒▒▒░░████▓▓▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒████           ");
                    Console.WriteLine("                          ▒▒▒▒▒▒▒▒  ░░░░░░▒▒▒▒  ██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▒▒▒▒░░██████████▒▒▒▒░░░░░░░░░░░░▒▒▒▒██▓▓       ");
                    Console.WriteLine("                      ▒▒▒▒▒▒  ░░▒▒  ░░░░░░▒▒▒▒  ████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▒▒▒▒░░████▓▓▒▒▒▒░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒██     ");
                    Console.WriteLine("                  ▒▒▒▒▒▒      ▒▒▒▒░░░░░░▒▒▒▒▒▒  ████████▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓██▒▒░░████▓▓░░░░░░░░            ░░░░░░░░▒▒██   ");
                    Console.WriteLine("               ▒▒▒▒▒▒░░      ▒▒░░░░░░░░░░░░▒▒▒▒██████████▓▓▓▓▓▓██████████████▓▓██▒▒░░████▓▓░░░░    ████████████    ░░░░▒▒▒▒██");
                    Console.WriteLine("             ▒▒▒▒▒▒▒▒    ░░▒▒░░░░░░░░░░░░░░▒▒▒▒██████▓▓▓▓▓▓▓▓████████████████▓▓██▒▒░░██████    ████    ░░▒▒▒▒▒▒████    ░░▒▒██");
                    Console.WriteLine("                  ▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒██████▓▓▓▓▓▓██████████████████▓▓██▒▒░░████████▓▓░░▒▒░░    ▒▒▒▒▒▒▒▒  ██▓▓  ░░▒▒ ");
                    Console.WriteLine("              ▒▒▒▒▒▒▒▒░░░░▒▒▒▒░░░░░░  ▒▒▒▒▒▒▒▒██████▓▓▓▓▓▓████████████████▓▓██▒▒▒▒▒▒████▓▓▒▒▒▒▒▒▒▒░░▒▒░░▒▒            ▓▓  ░░ ");
                    Console.WriteLine("            ▒▒▒▒░░░░░░░░░░▒▒▒▒░░░░    ▒▒▒▒▒▒▒▒██████▓▓▓▓██████████████████▓▓██▒▒▒▒▒▒████▓▓░░░░▒▒▒▒░░░░▒▒▒▒▒▒▒▒          ▓▓   ");
                    Console.WriteLine("            ▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒░░░░░░  ▒▒▒▒▒▒░░░░██████▓▓▓▓████████████████████▒▒▒▒▒▒▒▒▒▒████▓▓░░▒▒▒▒░░░░░░░░░░▒▒▒▒▓          ");
                    Console.WriteLine("                 ▒▒░░▒▒▒▒▒▒▒▒░░▒▒▒▒  ▒▒▒▒░░░░▓▓██████▓▓▓▓▓▓████████████████▒▒░░░░░░▒▒▒▒████▓▓░░░░▒▒▒▒░░░░░░▒▒▒▒▒▒░░          ");
                    Console.WriteLine("                ▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒░░▓▓██▓▓▓▓██████▓▓████████████████░░░░  ░░▒▒▒▒██████▒▒░░▒▒▒▒▒▒▒▒░░▒▒                 ");
                    Console.WriteLine("              ▒▒▒▒░░    ▒▒▒▒▒▒░░░░  ▒▒▓▓██▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓████░░    ░░░░▒▒████▓▓▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒                 ");
                    Console.WriteLine("              ▒▒░░    ▒▒░░░░▒▒░░    ▒▒▒▒██▓▓▓▓▓▓▓▓▓▓██▓▓██████▓▓▓▓████████▒▒▒▒░░░░░░▒▒████▓▓▒▒▒▒▒▒▒▒    ░░▒▒▒▒               ");
                    Console.WriteLine("              ▒▒░░  ▒▒▒▒░░░░▒▒░░  ▒▒▒▒██████▓▓▓▓▓▓▓▓████▓▓██████▓▓▓▓████████▒▒▒▒▒▒▒▒▒▒▓▓████▓▓▒▒░░░░▒▒    ░░▒▒               ");
                    Console.WriteLine("              ▒▒▒▒▒▒▒▒░░  ░░▒▒░░  ▒▒▒▒████████▓▓▓▓██████▓▓▓▓████████▓▓▓▓████████▒▒▒▒▒▒██████████░░░░▒▒▒▒  ▒▒▒▒               ");
                    Console.WriteLine("              ▒▒▒▒░░  ░░  ░░▒▒░░  ▒▒▒▒████████▓▓▓▓▓▓██████▓▓▓▓████▓▓▓▓▓▓████▓▓▓▓██████░░██████░░██  ░░▒▒▒▒▒▒▒▒               ");
                    Console.WriteLine("              ▒▒░░░░  ▒▒    ▒▒░░  ▒▒██████▓▓▓▓██████████████▓▓▓▓▓▓████▓▓██▓▓████▓▓████  ░░██▓▓░░██  ░░  ░░▒▒▒▒               ");
                    Console.WriteLine("              ▒▒░░  ▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒████▓▓██▓▓████  ████████████▓▓▓▓██▓▓██▓▓██▓▓▓▓████░░▓▓░░██▓▓  ░░▒▒  ░░░░▒▒               ");
                    Console.WriteLine("            ▒▒░░░░▒▒▒▒▒▒▒▒    ▒▒▒▒  ████▓▓████████    ████████████████████▓▓██████████▒▒██████▓▓  ▒▒▒▒▒▒  ░░▒▒               ");
                    Console.WriteLine("            ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░  ░░▒▒  ██████████████    ████████▓▓▓▓▓▓▓▓████████████████████████▓▓  ▒▒▒▒▒▒▒▒  ░░▒▒             ");
                    Console.WriteLine("            ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒  ██▒▒██████████  ▓▓▓▓▓▓▓▓██████████████████████████  ░░██████░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒             ");
                    Console.WriteLine("            ▒▒  ▒▒░░░░▒▒░░▒▒  ▒▒    ██▒▒░░░░░░████▓▓████████████████████████████████░░    ▒▒████▓▓▒▒▒▒░░▒▒▒▒▒▒▒▒             ");
                    Console.WriteLine("                ▒▒░░░░▒▒░░▒▒▒▒▒▒    ██▒▒░░  ░░░░████████▓▓▓▓▓▓████▓▓▓▓▓▓██  ████████        ██████░░▒▒░░  ▒▒  ▒▒             ");
                    Console.WriteLine("                ▒▒░░░░▒▒░░░░▒▒      ██▒▒░░  ██░░██████▓▓▓▓▓▓████████▓▓▓▓██      ████        ██████░░▒▒░░░░▒▒                 ");
                    Console.WriteLine("               ░░  ░░░░░░░░▒▒      ██▒▒▒▒░░████████▓▓▓▓██████▓▓▓▓▓▓██▓▓██                  ██████░░▒▒░░░░▒▒                  ");
                    Console.WriteLine("                ░░      ░░▒▒▒▒        ██▓▓▒▒░░██████▓▓██████████▓▓▓▓████████                ██████░░  ░░  ▒▒                 ");
                    Console.WriteLine("                ▒▒▒▒  ░░▒▒░░▒▒            ████████▓▓██▓▓██████▓▓▓▓▓▓▓▓▓▓████            ░░██████░░░░      ▒▒                 ");
                    Console.WriteLine("                  ░░    ░░▒▒▒▒                ██████▓▓██████████████▓▓▓▓▓▓██            ░░██████░░▒▒▒▒  ▒▒▒▒                 ");
                    Console.WriteLine("                 ▒▒▒▒    ▒▒▒▒▒▒              ████▓▓▓▓▓▓██████▓▓▓▓▓▓▓▓██▓▓██            ░░██████▒▒░░    ▒▒                    ");
                    Console.WriteLine("                    ▒▒▒▒░░░░▒▒▒▒            ████▓▓▓▓▓▓████████▓▓▓▓▓▓▓▓██▓▓████          ░░██████▒▒    ▒▒▒▒                   ");
                    Console.WriteLine("                      ▒▒▒▒░░░░▒▒            ████▓▓██▓▓████████▓▓████████▓▓████          ░░██████░░░░▒▒▒▒                     ");
                    Console.WriteLine("                       ▒▒░░░░▒▒            ████████████▓▓▓▓▓▓▓▓██████▓▓██████          ░░██████░░▒▒▒▒                        ");
                    Console.WriteLine("                        ▒▒░░░░▒▒            ████▓▓████████▓▓▓▓▓▓▓▓████████▓▓██        ░░▓▓████▒▒░░▒▒                         ");
                    Console.WriteLine("                         ▒▒▒▒▒▒          ▓▓████████████▓▓▓▓▓▓▓▓██████████▓▓██▓▓      ░░██████░░░░▒▒                          ");
                    Console.WriteLine("                            ▒▒▒▒░░        ████▓▓██▓▓████████████████████▓▓▓▓████      ░░██▓▓██▒▒░░                           ");
                    Console.WriteLine("                            ▒▒▒▒▒▒        ██████▓▓██████████████▓▓▓▓██▓▓▓▓▓▓▓▓██      ░░██████▒▒                             ");
                    Console.WriteLine("                              ▒▒▒▒      ████████▓▓▓▓▓▓████████▓▓▓▓██▓▓▓▓▓▓████████    ░░██████▒▒                             ");
                    Console.WriteLine("                                ▒▒      ██████████▓▓▓▓▓▓████▓▓▓▓▓▓▓▓██████████████      ████▓▓                               ");
                    Console.WriteLine("                                ▒▒    ██████████████████████████████████████████████  ░░████▓▓                               ");

                    Console.ReadKey();
                }


            }
            return terminado;
        }

    }
}
