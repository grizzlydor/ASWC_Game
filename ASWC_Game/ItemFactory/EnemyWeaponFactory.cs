using ASWC_Game.Enums;
using ASWC_Game.Interfaces;
using ASWC_Game.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game.WeaponFactory
{
    public class EnemyWeaponFactory : IArsenalFactory
    {
        public IWeapon CreateWeapon(ArsenalTypeEnum type)
        {
            if (type == ArsenalTypeEnum.Melee)
                return new Sword();
            if (type == ArsenalTypeEnum.Ranged)
                return new Bow();
            if (type == ArsenalTypeEnum.Defensive)
                return new Cloak();

            throw new ArgumentException($"DefenseWeaponFactory - no class available for weapon type {type}");
        }
    }

}
