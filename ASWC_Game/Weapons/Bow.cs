using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game.Weapons
{
    public class Bow : AttackItem
    {
        public override string Name
        {
            get { return "Bow"; }
        }
        public override int Damage
        {
            get { return 15; }
        }
        public override string Description
        {
            get { return "This is a bow"; }
        }
        public override int Range
        {
            get { return 10; }
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
