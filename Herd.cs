using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        public List<Dinosaur> dinosaurToChooseFrom;
        Random random = new Random();
        public Herd()
        {
            dinosaurToChooseFrom = new List<Dinosaur>();
            Dinosaur dinoOne = new Dinosaur("T-Rex", 100, 100, 5);
            Dinosaur dinoTwo = new Dinosaur("Brochiosaurus", 100, 100, 5);
            Dinosaur dinoThree = new Dinosaur("Velociraptor", 100, 100, 5);

            dinosaurToChooseFrom.Add(dinoOne);
            dinosaurToChooseFrom.Add(dinoTwo);
            dinosaurToChooseFrom.Add(dinoThree);

            int randomNumber = random.Next(0, 3);
            Dinosaur randomDinoCreated = dinosaurToChooseFrom[randomNumber];

           
        }
        


        
        
           
    }
}
