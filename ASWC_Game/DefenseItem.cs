using ASWC_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class DefenseItem : WorldObject, IWeapon
    {
        /// <summary>
        /// Decreases points by -1
        /// </summary>
        public abstract int Damage { get; }
        /// <summary>
        /// Description of the item
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>A string containing info about the item</returns>
        public override string ToString()
        {
            return $"{Name}:{Description}, dealing {Damage} damage points.";
        }
    }
}
