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

            RussianBlue rb = new RussianBlue("Peter");
            rb.printName();
            rb.makeSound();
            rb.beHappy();

            OrangeTabby ot = new OrangeTabby("Clair");
            ot.printName();
            ot.makeSound();
            ot.beHappy();
            ot.seeLaser();

            Garfield gar = new Garfield();
            gar.printName();
            gar.makeSound();
            gar.beHappy();
            gar.seeLaser();

            Console.ReadLine();
        }
    }
}
