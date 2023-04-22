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
        public string Simbolo;
        public ConsoleColor Color;

        public int _hp;
        public int _mana;

        protected bool Visible;
        protected string Ability;
        protected string _special;


        private string _atk1;
        private string _atk2;
        private string _atk3;
        private string _atk4;

        public Warrior(string name, int hp, int mana, string atk1, string atk2, string atk3, string atk4,
                    string special, int exp, int lvl, int x, int y, int velocx, int velocy, string ability, string simbolo,
                    ConsoleColor color, bool visible) : base(lvl, x, y)
        {
            Ability = ability;
            Simbolo = simbolo;
            Color = color;
            Visible = visible;
        }

        public int VidaExtra
        {
            get { return _hp; }

            set
            {
                _hp = value;
                vidaExtra();
            }
        }

        public int ManaExtra
        {
            get { return _mana; }

            set
            {
                _mana = value;
                manaExtra();
            }
        }

        public string ChangeAtaque1
        {

            get { return _atk1; }

            set
            {
                _atk1 = value;
                CambioAtaque1();
            }

        }

        public string ChangeAtaque2
        {

            get { return _atk2; }

            set
            {
                _atk2 = value;
                CambioAtaque2();
            }

        }

        public string ChangeAtaque3
        {

            get { return _atk3; }

            set
            {
                _atk3 = value;
                CambioAtaque3();
            }

        }

        public string ChangeAtaque4
        {

            get { return _atk4; }

            set
            {
                _atk4 = value;

                CambioAtaque4();
            }

        }

        public string ColdDownEspecialAtk
        {

            get { return _special; }

            set
            {
                _special = value;
                UsoAtaqueEspecial();
            }

        }

        public string EvolutionOfAbility
        {


            get { return _special; }

            set
            {
                _special = value;
                CambioDeHabilidadxNivel();
            }
        }

        public void vidaExtra()
        {

            _hp = _hp + 100;
        }

        public void manaExtra()
        {

            _mana = _mana + 200;
        }

        public void CambioAtaque1()
        {
            Console.WriteLine("Tu ataque1 a sido cambiado");
        }

        public void CambioAtaque2()
        {
            Console.WriteLine("Tu ataque2 a sido cambiado");
        }

        public void CambioAtaque3()
        {
            Console.WriteLine("Tu ataque3 a sido cambiado");
        }

        public void CambioAtaque4()
        {
            Console.WriteLine("Tu ataque4 a sido cambiado");

        }

        public void UsoAtaqueEspecial()
        {
            Console.WriteLine("Has usado el ataque Especial debes esperar 5 miuntos para volver a usarlo");
        }

        public void CambioDeHabilidadxNivel()
        {

            if (Lvl == 5)
            {
                Ability = "AntiMagia";
            }
            else if (Lvl >= 15)
            {
                Ability = "Necromancer";
            }
            else if (Lvl >= 25)
            {

                Ability = "Gran Mago";

            }

        }

    }
}
