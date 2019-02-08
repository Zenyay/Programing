using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Animal
    {
        //properties
        string species;
        string name;
        string color;
        int age;

        public Animal(string Color, string Name, string Species)
        {
            color = Color;
            name = Name;
            species = Species;
            age = 0;
        }

        public void makeSound()
        {
            Console.WriteLine("Grrrrr");
        }

        public void setAge(int newAge)
        {
            age = newAge;
        }

        public void printDiscription()
        {
            Console.WriteLine(name + " is a " + age + " year old, " + color + " " + species);
        }
    }
}
