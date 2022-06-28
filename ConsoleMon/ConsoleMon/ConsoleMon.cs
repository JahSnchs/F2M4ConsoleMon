using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonsters
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;
        internal Elements weakness;

        internal List<Skill> Skills = new List<Skill>();

        internal void TakeDmg(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energyCost)
        {
            energy -= energyCost;
        }

        internal ConsoleMon()
        {

        }

        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.health = copyFrom.health;
            this.energy = copyFrom.energy;
            this.name = copyFrom.name;
            this.weakness = copyFrom.weakness;

            foreach (Skill skill in copyFrom.Skills)
            {
                Skill pewpewCopy = new Skill(skill);
                Skills.Add(pewpewCopy);
            }
        }
    }
}
