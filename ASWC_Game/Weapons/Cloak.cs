using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game.Weapons
{
    public class Cloak : DefenseItem
    {
        public override string Name
        {
            get { return "Cloak"; }
        }
        public override int Damage
        {
            get { return 25; }
        }
        public override string Description
        {
            get { return "Issa cloak"; }
        }
        public override bool Removable
        {
            get { return true; }
        }
        public override bool Lootable
        {
            get { return false; }
        }
    }
}
