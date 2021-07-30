using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsExerciseProject_OOP_03.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, Gender gender) 
            : base(name, age, gender)
        {
            this.gender = Gender.female;
        }

        public override string ProduceSound()
        {
            string sound = "Kitten: Meow";
            return sound;
        }
        public override string ToString()
        {
            return "Kitten\n" + PrintInfo();
        }
    }
}
