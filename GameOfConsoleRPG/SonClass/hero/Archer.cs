using GameOfConsoleRPG.MotherClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfConsoleRPG.SonClass.hero
{
    public class Archer : Heros
    {
        public string Simbolo;
        public ConsoleColor Color;

        public int _hp;
        public int _mana;
        public int _damage;
        public string _lock;
        public bool _flecha;
        protected bool Visible;
        protected string Ability;
        protected string _special;


        private string _atk1;
        private string _atk2;
        private string _atk3;
        private string _atk4;

        public Archer(string name, int hp, int mana, string atk1, string atk2, string atk3, string atk4,
                    string special, int exp, int lvl, int x, int y, int velocx, int velocy, string ability, string simbolo,
                    ConsoleColor color, bool visible) : base(lvl, x, y)
        {
            Ability = ability;
            Simbolo = simbolo;
            Color = color;
            Visible = visible;
        }

        public bool  Flecha {
            get { return _flecha; }

            set
            {
                _flecha = value;
                FlechaArdiente();
            }

        }

        public int Tiro
        {
            get { return _hp; }

            set
            {
                _hp = value;
                TiroCertero();
            }
        }

        public int Distancia
        {
            get { return _mana; }

            set
            {
                _mana = value;
                DistanciaAlagarda();
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

        public void TiroCertero()
        {

            _damage = _damage + 100;
        }

        public void DistanciaAlagarda()
        {
            _lock = _lock + 1000;

            Console.WriteLine("El Usuario Tiene la mirada en el objetivo no puede fallar");
        }

        public void FlechaArdiente()
        {

            Console.WriteLine("Tiro Especial con flecha solo se puede usar una vez por partida");
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
