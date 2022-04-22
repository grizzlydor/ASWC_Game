using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game.Weapons
{
    public class Hoe : AttackItem
    {
        public override string Name
        {
            get { return "Hoe"; }
        }
        public override int Damage
        {
            get { return 5; }
        }
        public override string Description
        {
            get { return "This is a hoe"; }
        }
        public override int Range
        {
            get { return 1; }
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
