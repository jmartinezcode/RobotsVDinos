using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        int fleetSize;
        Random rand;
        List<string> names;
        public List<Robot> robots;
        public Fleet(Random rand)
        {
            names = new List<string>() { "BB8", "R2D2", "Bender" };
            this.rand = rand;
            fleetSize = 3;
            CreateRobotList();
        }

        public void CreateRobotList()
        {
            // this currently repeats whatever initial random selection is 
            // should randomize AFTER
            robots = Enumerable.Repeat(new Robot(names[rand.Next(0, names.Count)], rand.Next(20, 70)), fleetSize).ToList();
        }

    }
}
