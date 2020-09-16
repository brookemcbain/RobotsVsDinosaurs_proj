using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        string type; 
        double health = 100;
        double energy = 100;
        double attackPower;
        Random randomAttack;
        Random randomDino;
        public List<Dinosaur> dinosaurtype;
        public Dinosaur(string dinoType, double dinoHealth, double dinoEnergy, double dinoAttackPower)
        { 

            type = dinoType;
            health = dinoHealth;
            energy = dinoEnergy;
            attackPower = dinoAttackPower; 
           
        }
        public void AttackRobot()
        {
            Random randomAttack = new Random();
            double attackMode = randomAttack.Next(0, 6);
           
        }
   


           
                
                
                
           

  }
}
