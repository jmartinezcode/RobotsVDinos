using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        public List<Dinosaur> dinosaurs;        
        public Herd()
        {
            //CreateDinosaurList();
            dinosaurs = new List<Dinosaur>() { new Dinosaur("Anky", 20), new Dinosaur("Raptor", 35), new Dinosaur("Dactyl", 25) };
        }

        //public void CreateDinosaurList()
        //{
        //    // dinosaurs = Enumerable.Repeat(new Dinosaur(), herdSize).ToList();

        //}
    }
}
