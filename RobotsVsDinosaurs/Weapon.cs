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
        public double attackPower;
        Random rand;
        List<string> weaponDescriptorList;
        List<string> weaponTypeList;
        public string weaponDescriptor;
        public string weaponType; 

        public Weapon(Random rand)
        {
            weaponDescriptorList = new List<string>() {"Ion", "Pulse", "Laser", "Nano", "Proton", "Bio", "Plasma", "Mega"};
            weaponTypeList = new List<string>() { "Blaster", "Cannon", "Blade", "Rifle", "Ray", "Laser", "Gun", "Sword" };
            this.rand = rand;
            type = WeaponTypeGenerator();
            attackPower = WeaponStatGenerator();

        }

        public double WeaponStatGenerator()
        {
            return attackPower = rand.Next(75, 100);
        }
        public string WeaponTypeGenerator()
        {
            weaponDescriptor = weaponDescriptorList[rand.Next(0, weaponDescriptorList.Count)];
            weaponType = weaponTypeList[rand.Next(0, weaponTypeList.Count)];
            return type = weaponDescriptor + " " + weaponType;
        }

        // Possible Future Implementation To-Do:
        // Rarity and Random Stats on weapons


    }
}
