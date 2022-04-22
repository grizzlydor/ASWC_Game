using ASWC_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game
{
    public abstract class AttackItem : WorldObject, IWeapon
    {
        public abstract int Damage { get; }
        public abstract string Description { get; }
        public abstract int Range { get; }

        public override string ToString()
        {
            return $"{Name} : {Description}, dealing {Damage} damage points. Range {Range}";
        }
    }
}
