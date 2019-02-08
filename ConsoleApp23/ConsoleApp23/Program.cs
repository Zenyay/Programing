using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("White", "Alex", "Tiger");
            animal.makeSound();
            animal.setAge(5);
            animal.printDiscription();
            Console.ReadLine();
        }
    }
}
