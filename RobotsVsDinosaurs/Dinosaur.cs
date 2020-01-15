using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur : Warrior
    {
        public int attackPower;
        public Dinosaur(string name, int attackPower)
        {
            this.name = name;
            this.attackPower = attackPower;
            energy = 100;
        }
        public override void Attack(Warrior robot)
        {
            robot.health -= attackPower;
        }
    }
}
