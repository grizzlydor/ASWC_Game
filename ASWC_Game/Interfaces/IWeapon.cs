using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game.Interfaces
{
    public interface IWeapon
    {
        ///<summary>
        /// Factory design pattern
        ///</summary>
        string Description { get; }
        int Damage { get; }

    }
}
