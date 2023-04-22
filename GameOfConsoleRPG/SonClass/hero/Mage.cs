using GameOfConsoleRPG.MotherClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfConsoleRPG.SonClass.hero
{
    public class Mage : Heros
    {
        string Ability;
        public string Simbolo;
        public ConsoleColor Color;
        public bool Visible;

        public Mage(string name, int hp, int mana,string atk1, string atk2, string atk3, string atk4, 
                    string special, int exp, int lvl, int x, int y, int velocx, int velocy, string ability, string simbolo, 
                    ConsoleColor color, bool visible) : base(lvl, x, y)
        { 
            Ability = ability;
            Simbolo = simbolo;
            Color = color;
            Visible = visible;

        }
    }
}
