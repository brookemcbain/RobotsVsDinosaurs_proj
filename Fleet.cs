using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public List<Robot> robots;
        Random random = new Random();
        public Fleet()
        {
            robots = new List<Robot>(); 
            Robot robotOne = new Robot("Robot One", 100, 100, 100);
            Robot robotTwo = new Robot("Robot Two", 100, 100, 100); 
            Robot robotThree = new Robot("Robot Three", 100, 100, 100);

            robots.Add(robotOne);
            robots.Add(robotTwo);
            robots.Add(robotThree);

            int randomNumber = random.Next(0, 3);
            Robot randomDinoCreated = robots[randomNumber]; 
        }
       
    }
}
