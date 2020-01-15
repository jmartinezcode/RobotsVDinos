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
            //CreateDinosaurList();
            dinosaurs = new List<Dinosaur>() { new Dinosaur("Anky", 15), new Dinosaur("Raptor", 75), new Dinosaur("Dactyl", 55) };
        }

        //public void CreateDinosaurList()
        //{
        //    // dinosaurs = Enumerable.Repeat(new Dinosaur(), herdSize).ToList();

        //}
    }
}
