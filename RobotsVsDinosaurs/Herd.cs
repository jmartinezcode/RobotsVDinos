﻿using System;
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
            dinosaurs = new List<Dinosaur>() { new Dinosaur("Anky", 35), new Dinosaur("Raptor", 55), new Dinosaur("Dactyl", 45) };
        }

        //public void CreateDinosaurList()
        //{
        //    // dinosaurs = Enumerable.Repeat(new Dinosaur(), herdSize).ToList();

        //}
    }
}
