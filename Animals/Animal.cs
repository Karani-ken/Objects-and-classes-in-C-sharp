using System;


namespace Objects_and_classes_in_C_.Animals
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
}
