using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsExerciseProject_OOP_03.Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, Gender gender) 
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            string sound = "Frog: Frogggg";
            return sound;
        }
        public override string ToString()
        {
            return "Frog\n" + PrintInfo();
        }
    }
}
