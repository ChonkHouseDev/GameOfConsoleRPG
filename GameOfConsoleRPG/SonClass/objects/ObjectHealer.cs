﻿using GameOfConsoleRPG.MotherClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfConsoleRPG.SonClass.Objects
{
    public class ObjectHealer : ObjectsOfGame
    {
        public bool Respawn;
        public int Expobj;
        public bool Healing;
        public string Simbolo;
        public ConsoleColor Color;
        public bool Visible;
        public int _rearely;
        public string _reusable;
        public int _hp;
        public ObjectHealer(string name, string typeobjet, int lvl, bool damage, int valuedamage, bool reusable, int lvlusable, bool tresure, bool weapon, int x, int y, bool respawn, int expobj, bool healing,
                          string simbolo, ConsoleColor color, bool visible)
                          : base(name, typeobjet, lvl, damage, valuedamage, reusable, lvlusable, tresure, weapon, x, y)
        {

            Respawn = respawn;
            Expobj = expobj;
            Healing = healing;
            Simbolo = simbolo;
            Color = color;
            Visible = visible;
        }
        public int CuraunPocodevidaNormal
        {
            get { return _hp; }

            set
            {
                _hp = value;

            }

        }

        public int CuraunAlgodevidaNormal
        {
            get { return _hp; }

            set
            {
                _hp = value;

            }

        }

        public int CuraunMuchodevidaNormal
        {
            get { return _hp; }

            set
            {
                _hp = value;

            }

        }

        public int Aparicion
        {
            get { return _rearely; }

            set
            {
                _rearely = value;
                FrecuenciaDeAparicion();
            }

        }

        public void FrecuenciaDeAparicion()
        {
            _rearely = _rearely + 1;

            Console.WriteLine("Frecuencia Aparicion");
        }

        public void Reusable()
        {

            Console.WriteLine("Este Objeto es Reusable");
        }
    }
}
