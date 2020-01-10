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
        public List<Dinosaur> dinosaurs;
        public Herd()
        {
            herdSize = 3;
            CreateDinosaurList();
        }

        public void CreateDinosaurList()
        {
            dinosaurs = Enumerable.Repeat(new Dinosaur(), herdSize).ToList();
        }
    }
}
