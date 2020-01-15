using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot : Warrior
    {
        public Weapon weapon;
        Random rand;

        public Robot(string name, int energy)
        {
            this.name = name;
            this.energy = energy;
            
            // Create random weapon at initialization
            rand = new Random();
            List<string> weaponTypeList = new List<string>() { "Blaster", "Cannon", "Blade", "Rifle", "Ray", "Laser", "Gun", "Sword" };
            weapon = new Weapon(rand.Next(35, 45), weaponTypeList[rand.Next(weaponTypeList.Count)]);
        }

        public override void Attack(Warrior dinosaur)
        {
            dinosaur.health -= weapon.attackPower;
        }

        
    }
}
