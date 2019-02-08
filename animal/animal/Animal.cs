using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Animal
    {
        //properties
        string species;
        string name;
        //constructor
        public Animal(string Name, string Species)
        {
            name = Name;
            species = Species;
        }
        ///methods
        //makes sound
        public void makeSound()
        {
            Console.WriteLine("Grrrrr");
        }
        //gives animal name
        public void printName()
        {
            Console.WriteLine("Its name is " + name);
        }
    }
}
