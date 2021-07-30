using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsExerciseProject_OOP_03.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }
        public override string ProduceSound()
        {
            string sound = "Dog: BauBau";
            return sound;
        }
        public override string ToString()
        {
            return "Dog\n"+ PrintInfo();
        }
    }
}