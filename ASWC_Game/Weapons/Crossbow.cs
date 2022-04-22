using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game.Weapons
{
    public class Crossbow : AttackItem
    {
        public override string Name
        {
            get { return "Crossbow"; }
        }
        public override int Damage
        {
            get { return 45; }
        }
        public override string Description
        {
            get { return "This is a crossbow"; }
        }
        public override int Range
        {
            get { return 20; }
        }
        public override bool Lootable
        {
            get { return false; }
        }
        public override bool Removable
        {
            get { return false; }
        }
    }
}
