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
        public string attackPower;
        List<string> weaponDescriptorList;
        List<string> weaponTypeList;
        //RandomNumber random;
        int indexStart;
        

        public Weapon()
        {
            //List<string> weaponDescriptorList = new List<string> {"Ion", "Pulse", "Laser", "Nano", "Proton", "Bio", "Plasma", "Mega"};
            //List<string> weaponTypeList = new List<string> { "Blaster", "Cannon", "Blade", "Rifle", "Ray", "Laser", "Gun", "Sword" };
            WeaponNameCreator();
            WeaponStatGenerator();
            indexStart = 0;
            //random = new RandomNumber();
        }
        public int CalcRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void WeaponNameCreator()
        {
            //int descriptorIndex = CalcRandomNumber(indexStart, (weaponDescriptorList.Count - 1));
            //int typeIndex = CalcRandomNumber(indexStart, (weaponTypeList.Count - 1));
            
        }
        public void WeaponStatGenerator()
        {

        }
    }
}
