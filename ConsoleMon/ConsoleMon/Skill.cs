using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonsters
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDmg(damage);
        }

        internal Skill()
        {

        }

        internal Skill(Skill pewpew)
        {
            this.damage = pewpew.damage;
            this.energyCost = pewpew.energyCost;
            this.name = pewpew.name;
        }
    }

    internal enum Elements
    {
        Water,
        Fire,
        Earth,
        Air,
        Gay
    }
}
