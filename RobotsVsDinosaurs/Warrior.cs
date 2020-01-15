using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    abstract class Warrior
    {
        public string name;
        public int health;
        public int energy;
        public Warrior()
        {
            health = 100;
        }
        public abstract void Attack(Warrior warrior);

    }
}
