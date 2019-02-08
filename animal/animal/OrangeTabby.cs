using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class OrangeTabby
    {
        //properties
        string species;
        string name;
        //constructor
        public OrangeTabby(string Name)
        {
            name = Name;
            species = "Cat";
        }
        ///Methods
        //creates sound
        public void makeSound()
        {
            Console.WriteLine("Meow");
        }
        //gives name
        public void printName()
        {
            Console.WriteLine("Its name is " + name);
        }
        //the cats happy now
        public void beHappy()
        {
            layOnLap();
            Console.WriteLine("takes a nap");
        }
        //lays down
        public void layOnLap()
        {
            Console.WriteLine("cuddles on owners lap");
        }
        //laser race
        public void seeLaser()
        {
            Console.WriteLine("Cat pounces");
        }
    }
}
