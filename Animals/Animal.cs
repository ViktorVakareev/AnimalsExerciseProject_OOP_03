using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsExerciseProject_OOP_03.Animals
{
    public enum Gender
    {
        male,
        female
    };
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender gender;

        protected Animal(string name, int age, Gender gender)
        {
            if (string.IsNullOrEmpty(name) || age <= 0)
            {
                throw new ArgumentException($"Name = \"{name}\" age = \"{age}\": Invalid input\n");

            }
            Name = name;
            Age = age;
            this.gender = gender;
        }

        public abstract string ProduceSound();
        
        public string PrintInfo()
        {
            var sb = new StringBuilder();            
            sb.Append($"{Name} {Age} {this.gender}\n");
            sb.Append(ProduceSound()).Append("\n");

            return sb.ToString();
        }

    }
}
