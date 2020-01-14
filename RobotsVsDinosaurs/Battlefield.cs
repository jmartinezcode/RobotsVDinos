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
        public string side;

        public Battlefield()
        {
            rand = new Random();
            fleet = new Fleet(rand);
            herd = new Herd();
            ChooseSide();
            DisplayRobots();
            DisplayDinosaurs();
            RunBattlefield();
        }
        
               
        public void RunBattlefield()
        {
            // keeping track of players left in either team
            // for loop
                //print out current robot and dinosaur that is at the index of i
                // while loop (while either ones health is not less then or equal to 0)
                    // go back and forth attacking eachother
                    // maybe try to make attacks have a random chance of hitting
                    // if hit, minus health in the amount of opponents attack power
            // we need to check if a team won, if not grab next to and battle
        }

        public void ChooseSide()
        {
            Console.WriteLine("Choose Your Side (enter 1 or 2):\n1 Robots\n2 Dinosaurs");
            side = Console.ReadLine();
            switch (side)
            {
                case "1":
                    Console.WriteLine("Excellent choice you're sure to win!\nLet the battle commence!");
                    break;
                case "2":
                    Console.WriteLine("RAAAWWWRRR!!!! You chose wisely!\nLet's fight!");
                    break;
                default:
                    Console.WriteLine("Please Choose 1 or 2");
                    break;
            }
        }


        public void DisplayRobots()
        {
            Console.WriteLine("The Robot Fleet consists of:");
            Console.WriteLine(fleet.robots[0].name + " with a " + fleet.robots[0].powerLevel + " power level and a " + fleet.robots[0].weapon.type + " weapon.");
            Console.WriteLine(fleet.robots[1].name + " with a " + fleet.robots[1].powerLevel + " power level and a " + fleet.robots[1].weapon.type + " weapon.");
            Console.WriteLine(fleet.robots[2].name + " with a " + fleet.robots[2].powerLevel + " power level and a " + fleet.robots[2].weapon.type + " weapon.");
        }

        public void DisplayDinosaurs()
        {
            Console.WriteLine("The Dinsoaur Herd consists of:");
            Console.WriteLine(herd.dinosaurs[0].type);
            Console.WriteLine(herd.dinosaurs[1].type);
            Console.WriteLine(herd.dinosaurs[2].type);
        }
    }
}
