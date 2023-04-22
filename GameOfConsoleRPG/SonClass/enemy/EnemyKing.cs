using GameOfConsoleRPG.MotherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfConsoleRPG.SonClass.enemy
{
    public class EnemyKing : Enemys
    {
        string Ability;
        public string Simbolo;
        public ConsoleColor Color;
        public bool Visible;
        public EnemyKing(string name, int hp, int mana, string atk1, string atk2, int lvl, int x, int y, int velocx, int velocy, string ability, string simbolo,
              ConsoleColor color, bool visible) : base(name, hp, mana, atk1, atk2, lvl, x, y, velocx, velocx)
        {
            Ability = ability;
            Simbolo = simbolo;
            Color = color;
            Visible = visible;
        }
    }
}
