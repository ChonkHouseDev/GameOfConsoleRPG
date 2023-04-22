using GameOfConsoleRPG;
using GameOfConsoleRPG.MotherClass;
using GameOfConsoleRPG.SonClass.enemy;
using GameOfConsoleRPG.SonClass.hero;
using GameOfConsoleRPG.SonClass.Objects;

bool terminado = false;
int xMapa = 10, yMapa = 2;
int puntos;


//Heros InicioHeroe = new Heros("nombre", 100, 100, "golpe", "golpeObjeto",5, 40, 12, 0, 0);
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
    Console.WriteLine("2. Caballero");
    Console.WriteLine("3. Arquero");

    Console.Write("Ingrese una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            InicioHeroe.Nombre = "Merlin";
            InicioHeroe.Mana = 200;
            InicioHeroe.Highpoints = 80;
            InicioHeroe.Atk1     
            Mage merlin = new Mage(InicioHeroe.Nombre, InicioHeroe.Highpoints, InicioHeroe.ElMana, InicioHeroe.Atk1, InicioHeroe.Atk2, InicioHeroe.Lvl,
                       InicioHeroe.X, InicioHeroe.Y, InicioHeroe.velocx, InicioHeroe.velocy, "AntiMagia", "☃", ConsoleColor.Yellow, true);
            EnemyPeon[] peonesActualizados = InicioEnemigos.GeneradorDeEnemigos(peon);
            ObjectBomb[] itemsActualizados = InicioObjetos.GeneradorDeObjetos(objetos);

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
            break;
        case "2":
            Archer legolas = new Archer(InicioHeroe.Name, InicioHeroe.Hp, InicioHeroe.Mana, InicioHeroe.Atk1, InicioHeroe.Atk2, InicioHeroe.Lvl,
                       InicioHeroe.X, InicioHeroe.Y, InicioHeroe.velocx, InicioHeroe.velocy, "AntiFlechas", "☺", ConsoleColor.DarkBlue, true);
            break;
        case "3":
            Warrior ajax = new Warrior(InicioHeroe.Name, InicioHeroe.Hp, InicioHeroe.Mana, InicioHeroe.Atk1, InicioHeroe.Atk2, InicioHeroe.Lvl,
                        InicioHeroe.X, InicioHeroe.Y, InicioHeroe.velocx, InicioHeroe.velocy, "Inmunidad", "☠", ConsoleColor.DarkRed, true);
            return;
        default:
            Console.WriteLine("Opción inválida. Intente de nuevo.");
            break;
    }

    Console.WriteLine();
}




