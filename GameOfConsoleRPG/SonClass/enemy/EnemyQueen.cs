using GameOfConsoleRPG.MotherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfConsoleRPG.SonClass.enemy
{
    public class EnemyQueen : Enemys
    {
        string Ability;
        public string Simbolo;
        public ConsoleColor Color;
        public bool Visible;

        public int _damage;

        public int _atk1;

        public int _atk2;
        public EnemyQueen(string name, int hp, int mana, string atk1, string atk2, int lvl, int x, int y, int velocx, int velocy, string ability, string simbolo,
              ConsoleColor color, bool visible) : base(name, hp, mana, atk1, atk2, lvl, x, y, velocx, velocx)
        {
            Ability = ability;
            Simbolo = simbolo;
            Color = color;
            Visible = visible;
        }

        public int GolpeNormal
        {
            get { return _atk1; }

            set
            {
                _atk1 = value;
                Ataque1();
            }

        }

        public int GolpeCargado
        {
            get { return _atk2; }

            set
            {
                _atk2 = value;
                Ataque2();
            }
        }

        public void Ataque1()
        {
            _damage = _damage + 10;

            Console.WriteLine("Manotazo");

        }

        public void Ataque2()
        {
            _damage = _damage + 20;

            Console.WriteLine("Furia De la reina");
        }

        public void Deteccion()
        {

            Console.WriteLine("el enemigo te a visto");
        }
    }
}
