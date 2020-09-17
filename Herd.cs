using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    { 

        public List<Dinosaur> dinosaurs;
        Random random = new Random();
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            Dinosaur dinoOne = new Dinosaur("T-Rex");
            Dinosaur dinoTwo = new Dinosaur("Brochiosaurus");
            Dinosaur dinoThree = new Dinosaur("Velociraptor");
            dinosaurs.Add(dinoOne);
            dinosaurs.Add(dinoTwo);
            dinosaurs.Add(dinoThree);

            int randomNumber = random.Next(0, 3);
            Dinosaur randomDinoCreated = dinosaurs[randomNumber];
           
        }
  

        
        
           
    }
}
