using GameOfConsoleRPG.SonClass.enemy;
using GameOfConsoleRPG.SonClass.hero;
using GameOfConsoleRPG.SonClass.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameOfConsoleRPG.MotherClass
{
    public class Heros
    {
        public string Name;
        public int Hp;
        public int Mana;
        public string Atk1;
        public string Atk2;
        public int Lvl;
        public int X;
        public int Y;
        public int velocx;
        public int velocy;
        static int xMapa = 10, yMapa = 2;
        public string _name;
        public int _hp;
        public int _mana;
        static string[] mapa =
{
        "############################################     #",
        "#          #                            ##       #",
        "#                         ##                     #",
        "#          #                                     #",
        "#          #                                     #",
        "#          #                                     #",
        "#          #######################################",
        };


        public Heros(int lvl, int x, int y)
        {
  
            Lvl = lvl;
            X = x;
            Y = y;
        }
        public string Nombre
        {
            get { return _name; }

            set
            {
                _name = value;
            }
        }

        public int Highpoints
        {
            get { return _hp; }

            set
            {
                _hp = value;
            }
        }

        public int ElMana
        {
            get { return _mana; }

            set
            {
                _mana = value;
            }
        }

        public void ComprobarEntradayUsuario(Mage merlin)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if ((tecla.Key == ConsoleKey.LeftArrow)
                        && (EsPosibleMover(merlin.X - 1, merlin.Y)))
                    merlin.X--;

                if ((tecla.Key == ConsoleKey.RightArrow)
                        && (EsPosibleMover(merlin.X + 1, merlin.Y)))
                    merlin.X++;

                if ((tecla.Key == ConsoleKey.UpArrow)
                        && (EsPosibleMover(merlin.X, merlin.Y - 1)))
                    merlin.Y--;

                if ((tecla.Key == ConsoleKey.DownArrow)
                        && (EsPosibleMover(merlin.X, merlin.Y + 1)))
                    merlin.Y++;
            }

        }

        public bool EsPosibleMover(int x, int y)
        {

            x -= xMapa;
            y -= yMapa;

            try
            {
                if (mapa[y][x] == '#')
                    return false;
                else
                    return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public void PausaHastaFinDeFotograma()
        {
            Thread.Sleep(100);
        }

        public void DibujarCalabozo(Mage merlin, EnemyPeon[] peon, ObjectBomb[] items, int punto)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < mapa.Length; i++)
            {
                Console.SetCursorPosition(xMapa, yMapa + i);
                Console.Write(mapa[i]);
            }

            Console.ForegroundColor = merlin.Color;
            Console.SetCursorPosition(merlin.X, merlin.Y);
            Console.Write(merlin.Simbolo);

            for (int i = 0; i < peon.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(peon[i].x, peon[i].y);
                Console.Write(peon[i].Simbolo);
            }

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Visible)
                {

                    Console.ForegroundColor = items[i].Color;
                    Console.SetCursorPosition(items[i].X, items[i].Y);
                    Console.Write(items[i].Simbolo);
                }
            }

            Console.SetCursorPosition(1, 1);
            Console.Write("Puntos: " + punto);
        }

    }
}
