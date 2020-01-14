using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        public string type;
        public int attackPower;
        public Weapon(int attackPower, string type)
        {
            this.attackPower = attackPower;
            this.type = type;
        }
    }
}
