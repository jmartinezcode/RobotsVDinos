using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public List<Robot> robots;
        public Fleet()
        {
            Random rand = new Random();
            List<string> robotList = new List<string>() { "R2-D2", "BB-8", "Z0-E3", "C-3PO", "IG-88", "K-2SO", "L3-37" };
            robots = new List<Robot>() { new Robot(robotList[rand.Next(0, robotList.Count)], rand.Next(20, 70)), 
                new Robot(robotList[rand.Next(0, robotList.Count)], rand.Next(20, 70)), 
                new Robot(robotList[rand.Next(0, robotList.Count)], rand.Next(20, 70)) };
        }
    }
}
