using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects_and_classes_in_C_.Animals;
namespace Objects_and_classes_in_C_
{
   
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
