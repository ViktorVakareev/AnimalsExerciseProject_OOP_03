using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsExerciseProject_OOP_03.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, Gender gender) 
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            string sound = "Cat: MeowMeow";
            return sound;
        }
        public override string ToString()
        {
            return "Cat\n" + PrintInfo();
        }
    }
}
