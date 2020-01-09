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
            NameSelection();
        }

        public void NameSelection()
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
    }
}
