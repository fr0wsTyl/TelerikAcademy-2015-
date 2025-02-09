/*
 * Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
 * Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
 * Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
 * Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
*/
namespace Problem_3.Animal_hierarchy
{
    using System;
    public class Tomcat : Cat
    {
        private const string MALE_NAME = "male";
        public string Sex { get; set; }

        public Tomcat(int inputAge, string inputName)
            : base(inputAge, inputName, MALE_NAME)
        {

        }
        public override void Sound()
        {
            Console.WriteLine("MMMRRRRR");
        }
    }
}