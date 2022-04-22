using ASWC_Game.Enums;
using ASWC_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWC_Game
{
    public class Mob : IMob
    {
        public int Hitpoints { get; set; }
        public string Name { get; set; }
        public MobStateEnum CurrentStateEnum { get; set; }
        public List<MobStateEnum> MobStates { get; set; }
        public WorldObjectsEnum CurrentWorldObject { get; set; }
        public Dictionary<WorldObjectsEnum, IWorldObject> mobStateWithWorldObject { get; }
        public Position Position { get; set; }
        

        public Mob(string name, Position Position, WorldObjectsEnum initialStateWorldObject = WorldObjectsEnum.emptyHanded)
        {
            CurrentStateEnum = MobStateEnum.idle;
            Name = name;
            this.Position = Position;
            Hitpoints = 100;
            CurrentWorldObject = initialStateWorldObject;
            mobStateWithWorldObject = new Dictionary<WorldObjectsEnum, IWorldObject>();

        }

        public List<AttackItem> attackItems = new List<AttackItem>();
        public List<DefenseItem> defenseItems = new List<DefenseItem>();

        public void SetMobStateWithWorldObject(WorldObjectsEnum worldObj, IWorldObject behaviour)
        {
            mobStateWithWorldObject[worldObj] = behaviour;
        }

        public void ActBehaviour()
        {
            if (mobStateWithWorldObject.ContainsKey(CurrentWorldObject))
            {
                mobStateWithWorldObject[CurrentWorldObject].ChangeMobState();
            }
            else
            {
                throw new Exception($"No behaviours defined for state {CurrentWorldObject}");
            }
        }

        /// <summary>
        /// Calculates the points a mob gains when attacking their enemy.
        /// </summary>
        /// <param name="enemy"></param>
        public void Attack(Mob enemy)
        {
            var attacks = attackItems.Sum(AttackItem => AttackItem.Damage);
            enemy.ReceiveHits(attacks);
        }

        /// <summary>
        /// Check if world object is removable.
        /// If it is, it allows a mob to keep it, and adds it to the corresponding list.
        /// </summary>
        /// <param name="worldObject"></param>
        public void Loot(WorldObject worldObject)
        {
            if (worldObject.Removable)
            {
                if (worldObject is AttackItem)
                {
                    attackItems.Add(worldObject as AttackItem);
                }
                else if (worldObject is DefenseItem)
                {
                    defenseItems.Add(worldObject as DefenseItem);
                }
            }
        }

        /// <summary>
        /// Calculates the points a mob loses when they get hit by their enemy.
        /// </summary>
        /// <param name="hit"></param>
        public void ReceiveHits(int hit)
        {
            var defence = defenseItems.Sum(DefenceItem => DefenceItem.Damage);
            Hitpoints -= (hit - defence);
        }

        /// <summary>
        /// Checks if a mob is dead when their life points is equals to or less than 0.
        /// </summary>
        /// <returns></returns>
        public bool IsDead()
        {
            if (Hitpoints is <= 0)
            {
                Trace.ApplicationLog(TraceEventType.Information, $"Oh no! {Name} has died");
            }
            
            return Hitpoints is <= 0;
        }
        /// <summary>
        /// Checks who has the most hitpoints left
        /// </summary>
        /// <returns>A string that says which mob has won</returns>
        public bool IsWinner()
        {
            if (Hitpoints is > 0)
            {
                Trace.ApplicationLog(TraceEventType.Information, $"Congratulations! {Name} won!");
            }
            return Hitpoints > 0;
        }
    }
}
