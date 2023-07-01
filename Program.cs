using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_classes_in_C_
{
    public class Animal
    {
       public string name;
       public string family;
       public string type;
       public string sound;

        public void makeSound()
        {
            Console.WriteLine($"This animal is called a {name} and" +
                $" it is a {family}. \n It is a {type} animal and makes a {sound} sound");
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal();

            cow.name = "Cow";
            cow.family = "Mammal";
            cow.type = "Dairy";
            cow.sound = "Moooh";

            cow.makeSound();

            Console.ReadLine();
        }
    }
}
