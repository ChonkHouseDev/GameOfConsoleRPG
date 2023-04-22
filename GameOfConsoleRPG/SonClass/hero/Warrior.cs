using GameOfConsoleRPG.MotherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfConsoleRPG.SonClass.hero
{
    public class Warrior : Heros
    {
        string Ability;
        public Warrior(string name, int hp, int mana, string atk1, string atk2, int lvl, int x, int y, int velocx, int velocy, string ability, string simbolo,
              ConsoleColor color, bool visible) : base(lvl, x, y)
        {
            Ability = ability;
        }
    }
}
