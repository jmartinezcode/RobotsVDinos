using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        string name;
        double health;
        double powerlevel;
        Weapon weapon;

        public Robot()
        {
            weapon = new Weapon();
            RobotNameSelection();
            RobotAttack();
            RobotHealth();
            RobotPowerLevel();
        }

        public void RobotNameSelection()
        {
            //switch ()
            //{
            //    case 1:
            //        break;
            //    case 2:
            //        break;
            //    case 3:
            //        break;
            //    default:
            //        break;
            //}
        }
        public void RobotAttack()
        {

        }
        public void RobotHealth()
        {

        }
        public void RobotPowerLevel()
        {

        }
    }
}
