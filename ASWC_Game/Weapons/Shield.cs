using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game.Weapons
{
    public class Shield : DefenseItem
    {
        public override string Name
        {
            get { return "Shield"; }
        }
        public override int Damage
        {
            get { return 30; }
        }
        public override string Description
        {
            get { return "Issa shield"; }
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
