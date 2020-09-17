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
        public string type;
        public double health = 100;
        public double energy = 100;  
      
        Random random; 
        
        public Robot(string nameOfRobot)
        {
            health = 100;
            energy = 100; 
            type = nameOfRobot;
  
        }
        public void Weapon(string type, double powerLevel)
        {
            type = "Light Saber";
            powerLevel = 3; 
        }
        public void AttackDino(Dinosaur dinosaur)
        {
            random = new Random();
            double attackMode = random.Next(0, 6);

            for (index = 0; index > 0; index--;)
            {
                if (attackMode < 3)
                {
                    dinosaur.health -= 10;
                    energy -= 10;

                }
                else
                {
                    //dino health -= 20;
                    //robo energy -= 20; 
                }

            }

        }
       
    }
}
