using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game
{
    public abstract class WorldObject
    {
        public abstract string Name { get; }
        public abstract bool Lootable { get; }
        public abstract bool Removable { get; }

    }
}
