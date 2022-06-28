using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleMon battlerA = new ConsoleMon();
            ConsoleMon battlerB = new ConsoleMon();

            battlerA.health = 100;
            battlerB.health = 100;

            ConsoleMonArena arena = new ConsoleMonArena();

            Skill pewpew = new Skill();
            Skill bangbang = new Skill();

            pewpew.damage = 15;
            bangbang.damage = 20;

            battlerA.Skills.Add(pewpew);
            battlerA.Skills.Add(bangbang);
            battlerB.Skills.Add(pewpew);
            battlerB.Skills.Add(bangbang);

            arena.DoBattle(battlerA, battlerB);
        }

    }
}
