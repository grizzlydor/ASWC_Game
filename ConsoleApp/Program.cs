using ASWC_Game;
using ASWC_Game.Interfaces;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();

            Position positionMain = new Position(6, 4);
            Mob main = new Mob("Steve", positionMain);
            IWeapon mainsWeapon = CreateWeapons.GetMainsWeapon(main);
            main.attackItems.Add((AttackItem)mainsWeapon);

            Position positionEnemy = new Position(6, 5);
            Mob enemy = new Mob("Herobrine", positionEnemy);
            IWeapon enemyWeapon = CreateWeapons.GetEnemysWeapon(enemy);
            enemy.attackItems.Add((AttackItem)enemyWeapon);

            MobsFight.Fight(main, enemy);
        }
    }
}
