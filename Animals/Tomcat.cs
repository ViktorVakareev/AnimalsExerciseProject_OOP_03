using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsExerciseProject_OOP_03.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, Gender gender)
            : base(name, age, gender)
        {
            this.gender = Gender.male;
        }
        public override string ToString()
        {
            return "Tomcat\n" + PrintInfo();
        }
    }
}
