using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        public Herd newDino = new Herd();
        public Fleet newRobot = new Fleet();
        public Dinosaur dinoAttack = new Dinosaur(); 
        public Robot robotAttack = new Robot();
        



        public Battlefield()
        {
            Console.WriteLine("ROBOTS VS. DINOSAURS");
            Console.WriteLine("Player 1 will be:" + newDino.dinosaurs);
            Console.WriteLine("Player 2 will be:" + newRobot.robots);
            
            dinoAttack.Dinosaur(robotAttack); 
            robotAttack.AttackDino(dinoAttack);
            dinoAttack.attackPower(robotAttack); 

        }
            
    }

}
