using GameOfConsoleRPG.MotherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfConsoleRPG.SonClass.Objects
{
    public class ObjectBow : ObjectsOfGame
    {
        public bool Respawn;
        public int Expobj;
        public bool Healing;
        public string Simbolo;
        public ConsoleColor Color;
        public bool Visible;
        public ObjectBow(string name, string typeobjet, int lvl, bool damage, int valuedamage, bool reusable, int lvlusable, bool tresure, bool weapon, int x, int y, bool respawn, int expobj, bool healing,
                          string simbolo, ConsoleColor color, bool visible)
                          : base(name, typeobjet, lvl, damage, valuedamage, reusable, lvlusable, tresure, weapon, x, y)
        {
        }
    }
}
