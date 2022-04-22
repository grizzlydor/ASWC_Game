using ASWC_Game;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trace = ASWC_Game.Trace;

namespace ConsoleApp
{
    public class MobsFight
    {
        public static void Fight(Mob main, Mob enemy)
        {
            Console.WriteLine("-------------------------------------------");
            while (main.IsDead() != true && enemy.IsDead() != true)
            {
                main.Attack(enemy);
                Console.WriteLine($"{main.Name} hit {enemy.Name}");
                Console.WriteLine("-------------------------------------------");
                if (enemy.IsDead() != true)
                {
                    enemy.Attack(main);
                    Console.WriteLine($"{enemy.Name} hit {main.Name}");
                    Console.WriteLine("----------------------------------------");
                }
                else
                {
                    break;
                }
            }
            if (main.IsWinner() || enemy.IsWinner())
            {
                Trace.ApplicationLog(TraceEventType.Information, $"{main.Name} has {main.Hitpoints} hitponts left");
                Trace.ApplicationLog(TraceEventType.Information, $"{enemy.Name} has {enemy.Hitpoints} hitponts left");
            }
        }
    }
}
