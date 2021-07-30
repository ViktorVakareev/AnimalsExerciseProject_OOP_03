using AnimalsExerciseProject_OOP_03.Animals;
using System;

namespace AnimalsExerciseProject_OOP_03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // valid inputs
            var cat1 = new Cat("Djoko", 9, Gender.male);
            var dog1 = new Dog("Andy", 11, Gender.male);
            var frog1 = new Frog("Miki", 3, Gender.female);
            var kitten1 = new Kitten("Mini", 1, Gender.male);
            var tomcat1 = new Tomcat("Max", 1, Gender.male);

            Console.WriteLine(cat1);
            Console.WriteLine(dog1);
            Console.WriteLine(frog1);
            Console.WriteLine(kitten1);
            Console.WriteLine(tomcat1);

            // invalid inputs
            //var cat2 = new Cat("Wrong_cat", -9, Gender.male);             // negative value for age
            //var dog2 = new Dog("Wrong_dog", 0, Gender.male);               // 0 for age
            //var frog2 = new Frog("", 3, Gender.female);           // empty string for name
            //var kitten2 = new Kitten(null, 1, Gender.male);   // null for name
            //var tomcat2 = new Tomcat("Maximus", 1, Gender.female);  // try wrong gender for Tomcat
            //var kitten3 = new Kitten("Missy", 1, Gender.male);       // try wrong gender for Kitten
            //Console.WriteLine(kitten3);
            //Console.WriteLine(tomcat2);
        }
    }
}
