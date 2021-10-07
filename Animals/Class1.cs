using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    // Author : Raj Barot
    // Purpose : Create 2 classes and an interface. // PE 14
    public abstract class Pets
    {
        private string petname;

        public string petrwmethod  // read write property
        {
            get => petname;
            set => petname = value;
        }
    }

    public interface PetEat  // Interface
    {
        void Eat();
    }

    public class Dog : PetEat  // Dog class
    {
        public void Eat()
        {
            Console.WriteLine("Eat Happy");
        }
    }

    public class Cat : PetEat  // Cat class
    {
        public void Eat()
        {
            Console.WriteLine("Spill the Food");
        }
    }
}
