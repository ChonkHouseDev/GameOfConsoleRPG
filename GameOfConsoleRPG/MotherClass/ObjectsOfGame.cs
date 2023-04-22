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
        //public
        public bool terminado = false;
        public string Name;
        public string TypeObjet;
        public int Lvl;
        public int X;
        public int Y;
        public int ValueDamage;
        public string _mensaje;
        
        //private
        public bool Reusable;
        public int LvlUsable;
        public bool Tresure;
        public bool Weapon;
        public bool Damage;

        //protected
        protected int numItems;
        protected int itemsRestantes;
        protected int puntos;
        protected Random generador;






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


        public string BolsaVacia
        {
            get { return _mensaje; }

            set
            {
                _mensaje = value;
                MensajedeBolsaVacia();
            }

        }

        public string BolsaLlena
        {
            get { return _mensaje; }

            set
            {
                _mensaje = value;
                MensajedeBolsaLlena();
            }
        }

        public string Tesoro
        {
            get { return _mensaje; }

            set
            {
                _mensaje = value;
                MensajedeEncontrasteunTesro();
            }
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

        private void MensajedeBolsaLlena()
        {

            Console.WriteLine("Tu Bolsa esta llena");

        }

        private void MensajedeBolsaVacia()
        {

            Console.WriteLine("Tu Bolsa esta Vacia");

        }

        private void MensajedeEncontrasteunTesro()
        {

            Console.WriteLine("Has Encontrado un tesoro");

        }

        private ObjectBow[] GeneradorDeObjetosBow(ObjectBow[] itemBow)
        {
            generador = new Random();
            numItems = itemBow.Length - 1;
            itemsRestantes = numItems;
            for (int i = 0; i < numItems; i++)
            {
                itemBow[i].X = generador.Next(5, 55);
                itemBow[i].Y = generador.Next(2, 20);
                itemBow[i].Color = itemBow[itemsRestantes].Color;
                itemBow[i].Simbolo = itemBow[itemsRestantes].Simbolo;
                itemBow[i].Visible = itemBow[itemsRestantes].Visible;
            }


            puntos = 0;

            return itemBow;
        }

        private ObjectHealer[] GeneradorDeObjetosHealer(ObjectHealer[] itemHealer)
        {
            generador = new Random();
            numItems = itemHealer.Length - 1;
            itemsRestantes = numItems;
            for (int i = 0; i < numItems; i++)
            {
                itemHealer[i].X = generador.Next(5, 55);
                itemHealer[i].Y = generador.Next(2, 20);
                itemHealer[i].Color = itemHealer[itemsRestantes].Color;
                itemHealer[i].Simbolo = itemHealer[itemsRestantes].Simbolo;
                itemHealer[i].Visible = itemHealer[itemsRestantes].Visible;
            }


            puntos = 0;

            return itemHealer;
        }

        protected ObjectStickMage[] GeneradorDeObjetosStickMage(ObjectStickMage[] itemStickMage)
        {
            generador = new Random();
            numItems = itemStickMage.Length - 1;
            itemsRestantes = numItems;
            for (int i = 0; i < numItems; i++)
            {
                itemStickMage[i].X = generador.Next(5, 55);
                itemStickMage[i].Y = generador.Next(2, 20);
                itemStickMage[i].Color = itemStickMage[itemsRestantes].Color;
                itemStickMage[i].Simbolo = itemStickMage[itemsRestantes].Simbolo;
                itemStickMage[i].Visible = itemStickMage[itemsRestantes].Visible;
            }


            puntos = 0;

            return itemStickMage;
        }

        protected ObjectSword[] GeneradorDeObjetosSword(ObjectSword[] itemSword)
        {
            generador = new Random();
            numItems = itemSword.Length - 1;
            itemsRestantes = numItems;
            for (int i = 0; i < numItems; i++)
            {
                itemSword[i].X = generador.Next(5, 55);
                itemSword[i].Y = generador.Next(2, 20);
                itemSword[i].Color = itemSword[itemsRestantes].Color;
                itemSword[i].Simbolo = itemSword[itemsRestantes].Simbolo;
                itemSword[i].Visible = itemSword[itemsRestantes].Visible;
            }


            puntos = 0;

            return itemSword;
        }

        protected ObjectShield[] GeneradorDeObjetosShield(ObjectShield[] itemShield)
        {
            generador = new Random();
            numItems = itemSword.Length - 1;
            itemsRestantes = numItems;
            for (int i = 0; i < numItems; i++)
            {
                itemSword[i].X = generador.Next(5, 55);
                itemSword[i].Y = generador.Next(2, 20);
                itemSword[i].Color = itemSword[itemsRestantes].Color;
                itemSword[i].Simbolo = itemSword[itemsRestantes].Simbolo;
                itemSword[i].Visible = itemSword[itemsRestantes].Visible;
            }


            puntos = 0;

            return itemSword;
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

        private void MensajedeBolsaLena() {

            Console.WriteLine("Tu Bolsa esta llena");

        }
    }
}
