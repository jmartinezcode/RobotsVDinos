using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        public string name;
        public double health;
        public double powerLevel;
        public Weapon weapon;
        Random rand;
        
        public Robot(string name, double powerLevel)
        {
            health = 100;
            this.powerLevel = powerLevel;
            rand = rand;
            weapon = new Weapon(rand);
            //RobotAttack();
        }

        
    }
}
