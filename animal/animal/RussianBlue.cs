using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class RussianBlue
    {
        //properties
        string species;
        string name;
        //constructor
        public RussianBlue(string Name)
        {
            name = Name;
            species = "Cat";
        }
        ///Methods
        //creates sound
        public void makeSound()
        {
            Console.WriteLine("Hisss");
        }
        //gives name
        public void printName()
        {
            Console.WriteLine("Its name is " + name);
        }
        //the cats happy now
        public void beHappy()
        {
            Console.WriteLine("Purrrrrr");
            seeLaser();
        }
        //laser race
        public void seeLaser()
        {
            Console.WriteLine("Cat pounces");
        }
    }
}
