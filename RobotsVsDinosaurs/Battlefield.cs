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
            do
            {
                foreach (Dinosaur dinosaur in herd.dinosaurs)
                {
                    if (dinosaur.health > 0)
                    {
                        foreach (Robot robot in fleet.robots)
                        {
                            int attack = random.Next(100);
                            if (robot.health > 0 && attack > 34)
                            {
                                dinosaur.Attack(robot);
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
                            int attack = random.Next(100);
                            if (dinosaur.health > 0 && attack > 4)
                            {
                                robot.Attack(dinosaur);
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
            } while (true);
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
                Console.WriteLine("There were {0} survivors", fleetSize - deadRobots);
                Console.WriteLine("There were {0} dinosaurs killed", deadDinosaurs);
                Console.ReadLine();
            }
            else if(deadRobots == fleetSize)
            {
                Console.WriteLine("The Dinosaurs won!");
                Console.WriteLine("There were {0} survivors", herdSize - deadDinosaurs);
                Console.WriteLine("There were {0} robots killed", deadRobots);
                Console.ReadLine();
            }
            else
            {
                RunBattlefield();
            }
        }
    }
}
