using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class ClassAbstract
    {
        public abstract void eat();
        public void sound() {
            Console.WriteLine("Can hear sound from animal");
        }
    }
}

class Dog : ClassAbstract
{
    public override void eat()
    {
        Console.WriteLine("Dog eats bones");
    }
}
