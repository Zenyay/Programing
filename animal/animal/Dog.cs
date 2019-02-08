using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Dog
    {
        //properties
        string name;
        string species;
        bool dockedTail;
        //constructor
        public Dog(string Name, bool DT)
        {
            name = Name;
            dockedTail = DT;
            species = "Dog";
        }
        ///methods
        //gives sound
        public void makeSound()
        {
            Console.WriteLine("Woof");
        }
        //gives name
        public void printName()
        {
            Console.WriteLine("Its name is " + name);
        }
        //has dog play catch
        public void playFetch()
        {
            Console.WriteLine(name+" chases ball 5 times then quits");
        }
        //returns the dt property
        public bool getDockedTail()
        {
            return dockedTail;
        }
    }
}
