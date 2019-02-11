using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Leo", "Tiger");
            animal.printName();
            animal.makeSound();

            Cat cat = new Cat("Alex");
            cat.printName();
            cat.beHappy();

            Dog dog = new Dog("Ralph", true);
            dog.printName();
            dog.makeSound();
            dog.playFetch();
            dog.getDockedTail();



            Console.ReadLine();
        }
    }
}
