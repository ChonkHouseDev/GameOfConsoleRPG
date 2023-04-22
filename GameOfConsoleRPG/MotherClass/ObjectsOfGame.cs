using GameOfConsoleRPG.SonClass.enemy;
using GameOfConsoleRPG.SonClass.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfConsoleRPG.MotherClass
{

    public class ObjectsOfGame
    {
        public string Name;
        public string TypeObjet;
        public int Lvl;
        public bool Damage;
        public int ValueDamage;
        public bool Reusable;
        public int LvlUsable;
        public bool Tresure;
        public bool Weapon;
        public int X;
        public int Y;
        static int numItems;
        static int itemsRestantes;
        static int puntos;
        static Random generador;
        bool terminado = false;



        public ObjectsOfGame(string name, string typeobjet, int lvl, bool damage, int valuedamage, bool reusable, int lvlusable, bool tresure, bool weapon)
        {
            Name = name;
            TypeObjet = typeobjet;
            Lvl = lvl;
            Damage = damage;
            ValueDamage = valuedamage;
            Reusable = reusable;
            LvlUsable = lvlusable;
            Tresure = tresure;
            Weapon = weapon;
        }

        public ObjectsOfGame(string name, string typeobjet, int lvl, bool damage, int valuedamage, bool reusable, int lvlusable, bool tresure, bool weapon, int x, int y)
        {
            Name = name;
            TypeObjet = typeobjet;
            Lvl = lvl;
            Damage = damage;
            ValueDamage = valuedamage;
            Reusable = reusable;
            LvlUsable = lvlusable;
            Tresure = tresure;
            Weapon = weapon;
            X = x;
            Y = y;
        }

        public ObjectBomb[] GeneradorDeObjetosBomba(ObjectBomb[] items)
        {
            generador = new Random();
            numItems = items.Length - 1;
            itemsRestantes = numItems;
            for (int i = 0; i < numItems; i++)
            {
                items[i].X = generador.Next(5, 55);
                items[i].Y = generador.Next(2, 20);
                items[i].Color = items[itemsRestantes].Color;
                items[i].Simbolo = items[itemsRestantes].Simbolo;
                items[i].Visible = items[itemsRestantes].Visible;
            }


            puntos = 0;

            return items;
        }

        public (bool, int) ComprobaritemsUsuario(Heros merlin, ObjectBomb[] items)
        {
            itemsRestantes = items.Length;
            for (int i = 0; i < items.Length; i++)
            {
                if ((merlin.X == items[i].X) &&
                    (merlin.Y == items[i].Y) &&
                    items[i].Visible)
                {
                    puntos += 10;
                    items[i].Visible = false;
                    itemsRestantes--;
                    if (itemsRestantes <= 0)
                    {
                        terminado = true;
                        Console.Clear();
                        Console.WriteLine("Ganaste");
                        Console.ReadKey();
                    }
                }

            }

            return (terminado, puntos);
        }

    }
}
