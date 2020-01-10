using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        public Fleet fleet;
        public Herd herd;
        public Random rand;

        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
            ChooseSide();
        }
        
               
        public void RunBattlefield()
        {

        }
        public void ChooseSide()
        {
            Console.WriteLine("Choose Your Side (enter 1 or 2):\n1 Robots\n2 Dinosaurs");
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Excellent choice you're sure to win!");
                    break;
                case 2:
                    Console.WriteLine("RAAAWWWRRR!!!! You chose wisely!");
                    break;
                default:
                    Console.WriteLine("Please Choose 1 or 2");
                    break;
            }
        }
    }
}
