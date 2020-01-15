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
        //List<string> names;
        public List<Robot> robots;
        public Fleet()
        {
            //names = new List<string>() { "BB8", "R2D2", "Bender" };
            fleetSize = 3;
            //CreateRobotList();

            List<string> robotList = new List<string>() { "R2-D2", "BB-8", "Z0-E3", "C-3PO", "IG-88", "K-2SO", "L3-37" };
            robots = new List<Robot>() { new Robot(robotList[rand.Next(0, robotList.Count)], rand.Next(20, 70)), 
                new Robot(robotList[rand.Next(0, robotList.Count)], rand.Next(20, 70)), 
                new Robot(robotList[rand.Next(0, robotList.Count)], rand.Next(20, 70)) };
        }

        //public void CreateRobotList()
        //{
        //    // this currently repeats whatever initial random selection is 
        //    // should randomize AFTER
        //    robots = Enumerable.Repeat(new Robot(names[rand.Next(0, names.Count)], rand.Next(20, 70)), fleetSize).ToList();
        //}

    }
}
