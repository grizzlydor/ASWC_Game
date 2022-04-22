using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game.Interfaces
{
    public interface IMob
    {
        public void Attack(Mob enemy);
        public void Loot(WorldObject worldObject);
        public void ReceiveHits(int hit);
        public bool IsDead();
    }
}
