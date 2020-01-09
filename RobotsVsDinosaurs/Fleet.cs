using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public int fleetSize;
        public Fleet()
        {
            fleetSize = 3;
            CreateRobotList();
        }

        public void CreateRobotList()
        {
            List<Robot> robot = Enumerable.Repeat(new Robot(), fleetSize).ToList();
        }

    }
}
