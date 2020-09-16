using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        public Weapon sword; 

        public Weapon(string typeOfWeapon, double powerLevelOfWeapon)
        {
            sword = new Weapon("Light Saber", 100); 
        }

    }

}

