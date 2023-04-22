using GameOfConsoleRPG.MotherClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfConsoleRPG.SonClass.hero
{
    public class Archer : Heros
    {
        string Ability;
        public Archer(string name, int hp, int mana, string atk1, string atk2, string atk3, string atk4,
                    string special, int exp, int lvl, int x, int y, int velocx, int velocy, string ability, string simbolo,
                    ConsoleColor color, bool visible) :base(lvl, x, y)
        {
            Ability = ability;
        }




    }
}
