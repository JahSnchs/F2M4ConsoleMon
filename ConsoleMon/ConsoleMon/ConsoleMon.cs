using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMon
    {
        private int health;
        private int energy;
        private string name;

        List<Skill> Skills = new List<Skill>();

        internal void TakeDmg(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energyCost)
        {
            energy -= energyCost;
        }


    }
}
