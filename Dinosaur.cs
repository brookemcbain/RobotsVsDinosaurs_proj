using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        public string type;
        public double health;
        public double energy = 100; 
        public double attackPower;

        Robot roboHealth = new Robot();
        
        Random random = new Random(); 
      
        public Dinosaur(string dinoType)
        {

            type = dinoType;
        }
 
        public void AttackRobot(Robot robot)
        {
            random = new Random();
            double attackMode = random.Next(0, 6);

            for ()
            {
                if (attackMode < 3)
                {
                    roboHealth.Health -= 10;
                    energy -= 10;

                }
                else
                {
                    health -= 20;
                    energy -= 20;
                }
           
            }
          
        }
        public void Health()
        {
            health = 100; 
        }
        public void Energy()
        {
            energy = 100; 
        }







    }
}
