using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        string type;
        double health;
        double energy; 
        double powerLevel;
        Random random; 

        string typeOfWeapon;
        string powerLevelOfWeapon;
        string attackMode;


        public Robot(string nameOfRobot, double healthOfRobot, double energyOfRobot, double powerofRobot)
        {
            type = nameOfRobot;
            health = healthOfRobot;
            energy = energyOfRobot; 
            powerLevel = powerofRobot; 

        }
        public void AttackDino(Dinosaur dinosaur)
        {
            random = new Random();
            double attackMode = random.Next(0, 6);
            
            if (attackMode < 3)
            {
                health -= 10;
                energy -= 10; 
                           
            }
            else
            {
                health -= 20;
                energy -= 20; 
            }
        }
    }
}
