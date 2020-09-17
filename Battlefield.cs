using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        Herd newDino = new Herd();
        Fleet newRobot = new Fleet();
        Dinosaur dinoAttack = new Dinosaur();
        Robot robotAttack = new Robot();
        Weapon weapon = new Weapon(); 

        public Battlefield()

        { 


            //fleet.listName[0].AttackDino();

        }
        public void Introduction()
        {
            Console.WriteLine("ROBOTS VS. DINOSAURS");
            Console.WriteLine("Player 1 will be:" + newDino.dinosaurs);
            Console.WriteLine("Player 2 will be:" + newRobot.robots); 

        }
        public void BattleMode()
        {
            }
        }

        public void EndGame()
        {
            // win game message 
        }
    }

}
