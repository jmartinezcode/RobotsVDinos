using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        public string type;
        public double health;
        public double energy;
        public double attackPower;

        public Dinosaur()
        {
            CreateDinosaurType();
            CreateDinosaurHealth();
            CreateDinsoaurEnergy();
            CreateDinosaurAP();
        }

        public void CreateDinosaurType()
        {
            type = "melee";
        }
        public void CreateDinosaurHealth()
        {
            health = 100;
        }
        public void CreateDinsoaurEnergy()
        {
            energy = 100;
        }
        public void CreateDinosaurAP()
        {
            attackPower = 100;
        }

    }
}
