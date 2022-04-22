using ASWC_Game.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game.Interfaces
{
    public interface IArsenalFactory
    {
        IWeapon CreateWeapon(ArsenalTypeEnum type);
    }
}
