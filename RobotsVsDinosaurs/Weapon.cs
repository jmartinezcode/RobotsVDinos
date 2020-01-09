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
        List<string> weaponDescriptor;
        List<string> weaponType;

        public Weapon()
        {
            List<string> weaponDescriptorList = new List<string> { };
            WeaponNameCreator();
            WeaponStatGenerator();
        }

         
        public void WeaponNameCreator()
        {
            int min;
            int max;
            Battlefield.RandomNumber(1, 2);
        }
        public void WeaponStatGenerator()
        {

        }
    }
}
