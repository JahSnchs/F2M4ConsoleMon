using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonsters
{
    internal class ConsoleMonArena
    {
        internal void DoBattle(ConsoleMon battlerA, ConsoleMon battlerB)
        {
            Random random = new Random();

            battlerA.name = "Battler A";
            battlerB.name = "Battler B";

            if ((battlerA.health != 0) || (battlerB.health != 0))
            {
                while (battlerA.health >= 0 || battlerB.health >= 0)
                {
                    int rndA = random.Next(battlerA.Skills.Count);
                    int rndB = random.Next(battlerB.Skills.Count);
                    Skill skillA = battlerA.Skills[rndA];
                    Skill skillB = battlerB.Skills[rndB];

                    skillA.UseOn(battlerB, battlerA);
                    Console.WriteLine("Battler B's health is: " + battlerB.health + ". Battler A's damage was: " + skillA.damage + ".");
                    if (battlerB.health <= 0)
                    {
                        Console.WriteLine(battlerA.name + " wins!");
                        break;
                    }

                    skillB.UseOn(battlerA, battlerB);
                    Console.WriteLine("Battler A's health is: " + battlerA.health + ". Battler B's damage was: " + skillB.damage + ".");
                    if (battlerA.health <= 0)
                    {
                        Console.WriteLine(battlerB.name + " wins!");
                        break;
                    }
                }
            }
        }
    }
}
