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
        double powerLevel;
        Random random;

        string typeOfWeapon;
        string powerLevelOfWeapon; 


        public Robot(string type, double health, double powerLevel)
        {
            
           

        }
        public void Weapon(string type, double attackPower)
        {

        }
        public void AttackDino(///random dinosaur variable)
            //if attack power is < 2.5 then robot loses 10 health 
            //if attack power is > 2.5 then robot loses 20 health 
        {
            random = new Random();
            double attackMode = random.Next(0, 5);

            if (attackMode =< 2.5)
            {
                Dinosaur dinoPower = new Dinosaur();
                dinoPower.Health() && Energy(); 
                //get dinoPower.Health to equal to -10
                // energy will go down 
                
                
            }
         
        
        }
        public void Health()
        {

        }
        public void Energy()
        {

        }
    }
}
