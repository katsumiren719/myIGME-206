using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Pets
    {
        private string petname;

        public string petrwmethod
        {
            get => petname;
            set => petname = value;
        }
    }

    public interface PetEat
    {
        void Eat();
    }

    public class Dog : PetEat
    {
        public void Eat()
        {
            Console.WriteLine("Eat Happy");
        }
    }

    public class Cat : PetEat
    {
        public void Eat()
        {
            Console.WriteLine("Spill the Food");
        }
    }
}
