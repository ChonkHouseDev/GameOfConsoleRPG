using GameOfConsoleRPG.MotherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfConsoleRPG.SonClass.Objects
{
    public class ObjectSword : ObjectsOfGame
    {
        public ObjectSword(string name, string typeobjet, int lvl, bool damage, int valuedamage, bool reusable, int lvlusable, bool tresure, bool weapon, int x, int y) : base(name, typeobjet, lvl, damage, valuedamage, reusable, lvlusable, tresure, weapon, x, y)
        {
        }
    }
}
