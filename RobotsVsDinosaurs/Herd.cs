using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        public int herdSize;

        public Herd()
        {
            herdSize = 3;
            CreateDinosaurList();
        }

        public void CreateDinosaurList()
        {
            List<Dinosaur> dinosaur = Enumerable.Repeat(new Dinosaur(), herdSize).ToList();
        }
    }
}
