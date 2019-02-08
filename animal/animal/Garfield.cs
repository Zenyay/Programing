using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Garfield
    {
        //properties
        string species;
        string name;
        //constructor
        public Garfield()
        {
            name = "Garfield";
            species = "Cat";
        }
        ///Methods
        //creates sound
        public void makeSound()
        {
            Console.WriteLine("mmmm, lasagna");
        }
        //gives name
        public void printName()
        {
            Console.WriteLine("Its name is " + name);
        }
        //garfield is sleeping
        public void beHappy()
        {
            latOnLap();
            Console.WriteLine("*takes a nap*");
        }
        //cuddles for everyone
        public void latOnLap()
        {
            Console.WriteLine("*cuddles on owner's lap*");
        }
        //complete laser denile
        public void seeLaser()
        {
            beHappy();
        }
    }
}
