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
    public class MainsWeaponFactory : IArsenalFactory
    {
        public IWeapon CreateWeapon(ArsenalTypeEnum type)
        {
            if (type == ArsenalTypeEnum.Ranged)
                return new Crossbow();
            if (type == ArsenalTypeEnum.Melee)
                return new Axe();
            if (type == ArsenalTypeEnum.Defensive)
                return new Shield();
            throw new ArgumentException($"MainsWeaponFactory - no class available for weapon type {type}");
        }
    }
}
