using GameOfConsoleRPG;
using GameOfConsoleRPG.MotherClass;
using GameOfConsoleRPG.SonClass.enemy;
using GameOfConsoleRPG.SonClass.hero;
using GameOfConsoleRPG.SonClass.Objects;

bool terminado = false;

Heros InicioHeroe = new Heros(5, 40, 12);

Enemys InicioEnemigos = new Enemys("nombre", 100, 100, "golpe", "golpeEspecial", 1, 40, 12, 0, 0);

ObjectsOfGame InicioObjetos = new ObjectsOfGame("Arma","Consumible", 1, true, 10, false,5, false, false );


EnemyPeon[] peon = new EnemyPeon[3];

EnemyPeon peon1 = new EnemyPeon(InicioEnemigos.Name, InicioEnemigos.Hp, InicioEnemigos.Mana, InicioEnemigos.Atk1, InicioEnemigos.Atk2, InicioEnemigos.Lvl, InicioEnemigos.x,
                                InicioEnemigos.y, InicioEnemigos.velocx, InicioEnemigos.velocy, "Bloqueo", "♙", ConsoleColor.Red, true);
EnemyPeon peon2 = new EnemyPeon(InicioEnemigos.Name, InicioEnemigos.Hp, InicioEnemigos.Mana, InicioEnemigos.Atk1, InicioEnemigos.Atk2, InicioEnemigos.Lvl, InicioEnemigos.x,
                                InicioEnemigos.y, InicioEnemigos.velocx, InicioEnemigos.velocy, "Bloqueo", "♙", ConsoleColor.Red, true);
EnemyPeon peon3 = new EnemyPeon(InicioEnemigos.Name, InicioEnemigos.Hp, InicioEnemigos.Mana, InicioEnemigos.Atk1, InicioEnemigos.Atk2, InicioEnemigos.Lvl, InicioEnemigos.x,
                                InicioEnemigos.y, InicioEnemigos.velocx, InicioEnemigos.velocy, "Bloqueo", "♙", ConsoleColor.Red, true);

peon[0] = peon1;
peon[1] = peon2;
peon[2] = peon3;

ObjectBomb[] objetos = new ObjectBomb[20];


ObjectHealer[] ObjectHealers = new ObjectHealer[5];



ObjectSword[] ObjSwords = new ObjectSword[1];
ObjectStickMage[] stickmage = new ObjectStickMage[1];
ObjectShield[] ObjShields = new ObjectShield[1];
ObjectBow[] ObjectBows = new ObjectBow[1];


ObjectBomb obj1 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true,0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj2 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj3 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj4 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj5 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                       InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj6 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj7 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj8 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj9 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj10 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj11 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj12 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj13 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj14 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj15 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj16 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj17 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj18 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj19 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);
ObjectBomb obj20 = new ObjectBomb(InicioObjetos.Name, InicioObjetos.TypeObjet, InicioObjetos.Lvl, InicioObjetos.Damage, InicioObjetos.ValueDamage, InicioObjetos.Reusable,
                                        InicioObjetos.LvlUsable, InicioObjetos.Tresure, InicioObjetos.Weapon, 0, 0, true, 0, false, "●", ConsoleColor.Green, true);

objetos[0] = obj1;
objetos[1] = obj2;
objetos[2] = obj3;
objetos[3] = obj4;
objetos[4] = obj5;
objetos[5] = obj6;
objetos[6] = obj7;
objetos[7] = obj8;
objetos[8] = obj9;
objetos[9] = obj10;
objetos[10] = obj11;
objetos[11] = obj12;
objetos[12] = obj13;
objetos[13] = obj14;
objetos[14] = obj15;
objetos[15] = obj16;
objetos[16] = obj17;
objetos[17] = obj18;
objetos[18] = obj19;
objetos[19] = obj20;

while (true)
{
    Console.WriteLine("Elige un Personaje:");
    Console.WriteLine("1. Mago");
    Console.WriteLine("2. Arquero");
    Console.WriteLine("3. Caballero");

    Console.Write("Ingrese una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            InicioHeroe.Nombre = "Merlin";
            InicioHeroe.ElMana = 200;
            InicioHeroe.Highpoints = 80;
            InicioHeroe.Ataque1 = "Fire";
            InicioHeroe.Ataque2 = "Water";
            InicioHeroe.Ataque3 = "Earth";
            InicioHeroe.Ataque4 = "Thunder";
            InicioHeroe.Especialista = "";
            InicioHeroe.Experiencia = 0;

            Mage merlin = new Mage(InicioHeroe.Nombre, InicioHeroe.Highpoints, InicioHeroe.ElMana, InicioHeroe.Ataque1, InicioHeroe.Ataque2,
                                   InicioHeroe.Ataque3, InicioHeroe.Ataque4, InicioHeroe.Especialista, InicioHeroe.Experiencia,
                                   InicioHeroe.Lvl, InicioHeroe.X, InicioHeroe.Y, InicioHeroe.velocx, InicioHeroe.velocy, "AntiMagia",
                                   "☃", ConsoleColor.DarkGreen, true);

            EnemyPeon[] peonesActualizados = InicioEnemigos.GeneradorDeEnemigosPeones(peon);
            ObjectBomb[] itemsActualizados = InicioObjetos.GeneradorDeObjetosBomba(objetos);

            while (!terminado)
            {

                InicioHeroe.ComprobarEntradayUsuario(merlin);
                InicioEnemigos.AnimarElementos(peonesActualizados);
                bool terminadoEnemigos = InicioEnemigos.ComprobarEstadoDelJuegoEnemigos(peonesActualizados, merlin);
                (bool term, int punto) = InicioObjetos.ComprobaritemsUsuario(merlin, itemsActualizados);
                InicioHeroe.DibujarCalabozo(merlin, peonesActualizados, itemsActualizados, punto);
                if (terminadoEnemigos == true || term == true)
                    terminado = true;
                InicioHeroe.PausaHastaFinDeFotograma();
            }

            List<string> Listaagradecimiento = new List<string>();

            Listaagradecimiento.Add("Gracias");
            Listaagradecimiento.Add("Por Jugar");
            Listaagradecimiento.Add(merlin.Name);


            void ImprimirAgradecimientos1(List<string> listapersonajes)
            {
                foreach (string personaje in Listaagradecimiento)
                    Console.WriteLine(personaje);
            }
            break;
        case "2":

            InicioHeroe.Nombre = "Legolas";
            InicioHeroe.ElMana = 100;
            InicioHeroe.Highpoints = 100;
            InicioHeroe.Ataque1 = "Tiro a distancia";
            InicioHeroe.Ataque2 = "Tiro directo ";
            InicioHeroe.Ataque3 = "Tiro de Cerca";
            InicioHeroe.Ataque4 = "Tiro Envenado";
            InicioHeroe.Especialista = "";
            InicioHeroe.Experiencia = 0;

            Archer legolas = new Archer(InicioHeroe.Nombre, InicioHeroe.Highpoints, InicioHeroe.ElMana, InicioHeroe.Ataque1, InicioHeroe.Ataque2,
                                   InicioHeroe.Ataque3, InicioHeroe.Ataque4, InicioHeroe.Especialista, InicioHeroe.Experiencia,
                                   InicioHeroe.Lvl, InicioHeroe.X, InicioHeroe.Y, InicioHeroe.velocx, InicioHeroe.velocy,
                                   "AntiFlechas", "☺", ConsoleColor.DarkBlue, true);

            EnemyPeon[] peonesActualizado = InicioEnemigos.GeneradorDeEnemigosPeones(peon);
            ObjectBomb[] itemsActualizado = InicioObjetos.GeneradorDeObjetosBomba(objetos);

            while (!terminado)
            {

                InicioHeroe.ComprobarEntradayUsuariolegolas(legolas);
                InicioEnemigos.AnimarElementos(peonesActualizado);
                bool terminadoEnemigos = InicioEnemigos.ComprobarEstadoDelJuegoEnemigosLegolas(peonesActualizado, legolas);
                (bool term, int punto) = InicioObjetos.ComprobaritemsUsuario(legolas, itemsActualizado);
                InicioHeroe.DibujarCalabozoLegolas(legolas, peonesActualizado, itemsActualizado, punto);
                if (terminadoEnemigos == true || term == true)
                    terminado = true;
                InicioHeroe.PausaHastaFinDeFotograma();
            }


            List<string> Listaagradecimiento2 = new List<string>();

            Listaagradecimiento2.Add("Gracias");
            Listaagradecimiento2.Add("Por Jugar");
            Listaagradecimiento2.Add(legolas.Name);


            void ImprimirAgradecimientos(List<string> listapersonajes)
            {
                foreach (string personaje in Listaagradecimiento)
                    Console.WriteLine(personaje);
            }

            break;
        case "3":
            InicioHeroe.Nombre = "Ajax";
            InicioHeroe.ElMana = 80;
            InicioHeroe.Highpoints = 200;
            InicioHeroe.Ataque1 = "Hachazo";
            InicioHeroe.Ataque2 = "Lanza";
            InicioHeroe.Ataque3 = "Terremoto";
            InicioHeroe.Ataque4 = "Escudo";
            InicioHeroe.Especialista = "";
            InicioHeroe.Experiencia = 0;
            Warrior ajax = new Warrior(InicioHeroe.Nombre, InicioHeroe.Highpoints, InicioHeroe.ElMana, InicioHeroe.Ataque1, InicioHeroe.Ataque2,
                                   InicioHeroe.Ataque3, InicioHeroe.Ataque4, InicioHeroe.Especialista, InicioHeroe.Experiencia,
                                   InicioHeroe.Lvl, InicioHeroe.X, InicioHeroe.Y, InicioHeroe.velocx, InicioHeroe.velocy, 
                                   "Inmunidad", "☠", ConsoleColor.DarkRed, true);

            EnemyPeon[] peonesActualizad = InicioEnemigos.GeneradorDeEnemigosPeones(peon);
            ObjectBomb[] itemsActualizad = InicioObjetos.GeneradorDeObjetosBomba(objetos);

            while (!terminado)
            {

                InicioHeroe.ComprobarEntradayUsuarioajax(ajax);
                InicioEnemigos.AnimarElementos(peonesActualizad);
                bool terminadoEnemigos = InicioEnemigos.ComprobarEstadoDelJuegoEnemigosAjax(peonesActualizad, ajax);
                (bool term, int punto) = InicioObjetos.ComprobaritemsUsuario(ajax, itemsActualizad);
                InicioHeroe.DibujarCalabozoajax(ajax, peonesActualizad, itemsActualizad, punto);
                if (terminadoEnemigos == true || term == true)
                    terminado = true;
                InicioHeroe.PausaHastaFinDeFotograma();
            }

            List<string> Listaagradecimiento3 = new List<string>();

            Listaagradecimiento3.Add("Gracias");
            Listaagradecimiento3.Add("Por Jugar");
            Listaagradecimiento3.Add(ajax.Name);


            void ImprimirAgradecimientos3(List<string> listapersonajes)
            {
                foreach (string personaje in Listaagradecimiento)
                    Console.WriteLine(personaje);
            }
            return;
        default:
            Console.WriteLine("Opción inválida. Intente de nuevo.");
            break;
    }

    Console.WriteLine();
}




