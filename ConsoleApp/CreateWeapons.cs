using ASWC_Game;
using ASWC_Game.Enums;
using ASWC_Game.Interfaces;
using ASWC_Game.WeaponFactory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trace = ASWC_Game.Trace;

namespace ConsoleApp
{
    public class CreateWeapons
    {
        public static IWeapon GetWeaponType(IArsenalFactory factory)
        {
            Random random = new Random();
            int rand = random.Next(2);
            if (rand is 0)
            {
                IWeapon meleeWeapon = factory.CreateWeapon(ArsenalTypeEnum.Melee);
                return meleeWeapon;
            }
            else
            {
                IWeapon rangeWeapon = factory.CreateWeapon(ArsenalTypeEnum.Ranged);
                return rangeWeapon;
            }
        }
        public static IWeapon GetMainsWeapon(Mob main)
        {
            Trace.ApplicationLog(TraceEventType.Information, $"{main.Name} has his good guy weapons");
            
            return GetWeaponType(new MainsWeaponFactory());
        }

        public static IWeapon GetEnemysWeapon(Mob enemy)
        {
            Trace.ApplicationLog(TraceEventType.Information, $"{enemy.Name} has his villain weapons");
            return GetWeaponType(new EnemyWeaponFactory());
        }
    }
}
