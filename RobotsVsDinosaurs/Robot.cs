﻿using System;
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

            // Create random weapon at 
            List<string> weaponTypeList = new List<string>() { "Blaster", "Cannon", "Blade", "Rifle", "Ray", "Laser", "Gun", "Sword" };
            weapon = new Weapon(weaponTypeList[rand.Next(weaponTypeList.Count)]);
            //RobotAttack();
        }

        
    }
}
