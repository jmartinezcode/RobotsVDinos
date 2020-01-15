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
        public string side;

        int deadDinosaurs = 0;
        int deadRobots = 0;
        int fleetSize = 3;
        int herdSize = 3;

        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
            ChooseSide();
            DisplayRobots();
            DisplayDinosaurs();
            RunBattlefield();
        }
                      
        public void RunBattlefield()
        {
            Random random = new Random();
            while (deadDinosaurs != herdSize && deadRobots != fleetSize)
            {
                foreach (Dinosaur dinosaur in herd.dinosaurs)
                {
                    if (dinosaur.health > 0)
                    {
                        foreach (Robot robot in fleet.robots)
                        {
                            int attack = random.Next(10); //add 80% random chance
                            if (robot.health > 0 && attack > 1)
                            {
                                dinosaur.Attack(robot);
                                // Console.WriteLine("{0} is attacking {1}",dinosaur.name, robot.name);
                                if (robot.health <= 0)
                                {
                                    deadRobots++;
                                    Console.WriteLine("{0} just died! {1} killed it!", robot.name, dinosaur.name);
                                }
                            }
                        }
                    }
                }
                foreach (Robot robot in fleet.robots)
                {
                    if (robot.health > 0)
                    {
                        foreach (Dinosaur dinosaur in herd.dinosaurs)
                        {
                            //int attack = random.Next(10);  // robots have precision aim, removed chance from robots 
                            if (dinosaur.health > 0)
                            {
                                robot.Attack(dinosaur);
                                // Console.WriteLine("{0} is attacking {1}", robot.name, dinosaur.name);
                                if (dinosaur.health <= 0)
                                {
                                    deadDinosaurs++;
                                    Console.WriteLine("{0} just killed {1}!", robot.name, dinosaur.name);
                                }
                            }
                        }
                    }
                }
                DeclareWinner();
                break;
            }
        }

        public void ChooseSide()
        {
            Console.WriteLine("Choose Your Side (enter 1 or 2):\n1 Robots\n2 Dinosaurs");
            side = Console.ReadLine();
            switch (side)
            {
                case "1":
                    Console.WriteLine("Excellent choice you're sure to win!\nLet the battle commence!\n");
                    break;
                case "2":
                    Console.WriteLine("RAAAWWWRRR!!!! You chose wisely!\nLet's fight!");
                    break;
                default:
                    ChooseSide();
                    //Console.WriteLine("Please Choose 1 or 2");
                    break;
            }
        }               
        public void DisplayRobots()
        {
            Console.WriteLine("The Robot Fleet consists of:");
            Console.WriteLine("{0}, {1}, and {2}. Each has a {3} weapon that has {4} attack power.\n", fleet.robots[0].name, fleet.robots[1].name, fleet.robots[2].name, fleet.robots[0].weapon.type, fleet.robots[0].weapon.attackPower);
        }

        public void DisplayDinosaurs()
        {
            Console.WriteLine("The Dinsoaur Herd consists of: \n{0}, {1}, and {2}. \n", herd.dinosaurs[0].name, herd.dinosaurs[1].name, herd.dinosaurs[2].name);
        }
        public void DeclareWinner()
        {
            if (deadDinosaurs == herdSize)
            {
                Console.WriteLine("The Robots were victorious!");
                Console.ReadLine();         
            }
            else if (deadRobots == fleetSize)
            {
                Console.WriteLine("The Dinosaurs won!");
                Console.ReadLine();
            }
        }
    }
}
